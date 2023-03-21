using NAudio.Lame;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundRecord
{
	internal class Recaudio
	{

		WaveIn waveIn;
		WaveFileWriter waveWriter;
		private string _filename;
		private string _path;
		private string _tempFilename;


		private void waveIn_DataAvailable(object sender, WaveInEventArgs e)
		{
			if (waveWriter == null) return;

			waveWriter.Write(e.Buffer, 0, e.BytesRecorded);
			waveWriter.Flush();
		}


		public void RecordAudio(string path, string filename)
		{
			_filename = filename;
			_path = path;
			_tempFilename = $"{(path + filename)}.wav";

			waveIn = new WaveIn();
			waveIn.DeviceNumber = 0;
			waveIn.WaveFormat = new WaveFormat(44100, WaveIn.GetCapabilities(waveIn.DeviceNumber).Channels);

			waveIn.DataAvailable += new EventHandler<WaveInEventArgs>(waveIn_DataAvailable);
			waveWriter = new WaveFileWriter(_tempFilename, waveIn.WaveFormat);
			waveIn.StartRecording();
		}

		public void StopRecording()
		{

			if (waveIn != null)
			{
				waveIn.StopRecording();
				waveIn.Dispose();
				waveIn = null;
			}
			if (waveWriter != null)
			{
				waveWriter.Dispose();
				waveWriter = null;
			}
	//		ConvertWaveToMp3(_tempFilename, _path + _filename + ".mp3");
		}

		/// <summary>
		/// Преобразует записанный файл WAV в MP3.
		/// </summary>
		public void ConvertWaveToMp3(string source, string destination)
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
	}
}
