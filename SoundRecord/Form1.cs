using NAudio.CoreAudioApi;
using NAudio.Lame;
using NAudio.Wave;
using SoundRecord.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using ExtendedDotNET.Controls;



namespace SoundRecord
{
	public partial class Form1 : Form
	{
		private string dirPath = (string)(Settings.Default["Path"]) + @"\";
		private string filePath = "";
		private string tempfilePath = "";
		private string fileName = "";
		private string tempfile = "";
		private Recaudio rec = new Recaudio();
		private Recaudio recMP = new Recaudio();
		private bool _isRecordingStop = true;
		private bool _isRecordingPlay = false;
		

		public Form1()
		{
			InitializeComponent();
			textBox1Path.Text = (string)(Settings.Default["Path"]);	
			MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
			var devices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
			comboBox1.Items.AddRange(devices.ToArray());
			timer1.Interval = 1000;
			timer1.Tick += new EventHandler(timer1_Tick);
			timer1.Start();
			comboBox1.SelectedIndex = (int)(Settings.Default["ChannelID"]);
		}

		private void ConvertWaveToMp3(string source, string destination)
		{
			using (var waveStream = new WaveFileReader(source))
			using (var fileWriter = new LameMP3FileWriter(destination, waveStream.WaveFormat, 128))
			{
				waveStream.CopyTo(fileWriter);
				waveStream.Flush();
			}

			/*Delete the temporary WAV file*/
			File.Delete(source);
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			if (comboBox1.SelectedItem != null)
			{
				var device = (MMDevice)comboBox1.SelectedItem;
				progressBar2.Value = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100));
			}
		}

		private void settingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Setting setting = new Setting();
			setting.ShowDialog();
		}

		private void bRec_Click(object sender, EventArgs e)
		{
			if (_isRecordingStop & !_isRecordingPlay)
			{
				fileName = DateTime.Now.ToString("ddMMy-HHmm");
				tempfile = fileName;
				filePath = dirPath + DateTime.Now.Year.ToString() + @"\" + DateTime.Now.ToString("MM") + @"\" + DateTime.Now.ToString("dd");
				if (!Directory.Exists(filePath))
				{
					Directory.CreateDirectory(filePath);
				}
				tempfilePath = filePath;
			//	rec = new Recaudio();
				rec.RecordAudio(filePath + @"\", fileName);
				textBoxLog.Text = "Record start " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");
				_isRecordingPlay = true;				
			}	
		}

		private async void bStop_Click(object sender, EventArgs e)
		{			
			if (_isRecordingPlay)  
			{
				tempfile = fileName;
				tempfilePath = filePath;
				rec.StopRecording();
				Console.WriteLine("Stop");
				if (File.Exists($"{(tempfilePath + @"\" + tempfile)}.wav"))
				{
					await Convert();
//					ConvertWaveToMp3($"{(tempfilePath + @"\" + tempfile)}.wav", tempfilePath + @"\" + tempfile + ".mp3");
				}				
			}
			_isRecordingStop = true;
		}


		private void timer1_Tick(object sender, EventArgs e)
		{			
			if (_isRecordingPlay) 
			{				
				if (DateTime.Now.Minute.ToString("00") == "00" & DateTime.Now.Second.ToString("00") == "00")
				{					
					if (rec != null)
					{						
						rec.StopRecording();
					//	_isRecordingPlay = false;
						tempfile = fileName;
						tempfilePath = filePath;
						Console.WriteLine($"{(tempfilePath + @"\" + tempfile)}.wav" + " - 1");

						fileName = DateTime.Now.ToString("ddMMy-HHmm");
						filePath = dirPath + DateTime.Now.Year.ToString() + @"\" + DateTime.Now.ToString("MM") + @"\" + DateTime.Now.ToString("dd");
						if (!Directory.Exists(filePath))
						{
							Directory.CreateDirectory(filePath);
						}
						rec.RecordAudio(filePath + @"\", fileName);
						_isRecordingPlay = true;
						Thread.Sleep(1000);
					}
				}
			}

		}

		private async void timerMp3_Tick(object sender, EventArgs e)
		{
			if (DateTime.Now.Minute.ToString("00") == "00" & DateTime.Now.Second.ToString("00") == "05")
			{
				if (File.Exists($"{(tempfilePath + @"\" + tempfile)}.wav"))
				{
					Console.WriteLine("Convert");
					await Convert();
	//				ConvertWaveToMp3($"{(tempfilePath + @"\" + tempfile)}.wav", tempfilePath + @"\" + tempfile + ".mp3");
				}
			}
		}

		async Task Convert()
		{
			await Task.Run(() => ConvertWaveToMp3($"{(tempfilePath + @"\" + tempfile)}.wav", tempfilePath + @"\" + tempfile + ".mp3"));
		}

	}
}
