using NAudio.CoreAudioApi;
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

namespace SoundRecord
{
	public partial class Form1 : Form
	{
		private string dirPath = (string)(Settings.Default["Path"]) + @"\";
		private string filePath = "";
		private string fileName = "";
		private Recaudio rec;
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
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			if (comboBox1.SelectedItem != null)
			{
				var device = (MMDevice)comboBox1.SelectedItem;
				progressBar1.Value = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100));
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
				filePath = dirPath + DateTime.Now.Year.ToString() + @"\" + DateTime.Now.ToString("MM");
				if (!Directory.Exists(filePath))
				{
					Directory.CreateDirectory(filePath);
				}				
				rec = new Recaudio();
				rec.RecordAudio(filePath + @"\", fileName);
				textBoxLog.Text = "Record start " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");
				_isRecordingPlay = true;
			}	
		}

		private void bStop_Click(object sender, EventArgs e)
		{			
			if (rec != null) { rec.StopRecording(); }			
			_isRecordingStop = true;
			Console.WriteLine(DateTime.Now.ToString("ddMMy-HHmm"));
		}


		private void timer1_Tick(object sender, EventArgs e)
		{			
			if (_isRecordingPlay) 
			{				
				if (DateTime.Now.Minute.ToString("00") == "56" & DateTime.Now.Second.ToString("00") == "59")
				{					
					if (rec != null)
					{						
						rec.StopRecording();
						_isRecordingPlay = false;
					}
				}
			}
			if (_isRecordingStop)
			{
				if (DateTime.Now.Minute.ToString("00") == "57" & DateTime.Now.Second.ToString("00") == "00")
				{
					if (rec != null)
					{
						fileName = DateTime.Now.ToString("ddMMy-HHmm");
						filePath = dirPath + DateTime.Now.Year.ToString() + @"\" + DateTime.Now.ToString("MM");
						if (!Directory.Exists(filePath))
						{
							Directory.CreateDirectory(filePath);
						}
						//				rec = new Record();
						rec.RecordAudio(filePath + @"\", fileName);
						_isRecordingPlay = true;
					}
				}
			}

		}





	}
}
