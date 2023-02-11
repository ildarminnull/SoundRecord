using NAudio.Lame;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SoundRecord
{
	public class Record
	{		

		private WaveInEvent _waveSource;
		private WaveFileWriter _waveWriter;
		private string _filename;
		private string _path;
		private string _tempFilename;
		
		//public event EventHandler RecordingFinished;

		/// <summary>
		/// Запись с микрофона
		/// </summary>
		/// <param name="seconds">Duration in seconds</param>
		/// <param name="filename">Output file name</param>
		public void RecordAudio(string path, string filename)
		{
			/*если имя файла пусто, выдать исключение*/
			if (string.IsNullOrEmpty(filename))
				throw new ArgumentNullException("The file name cannot be empty.");

			_filename = filename;
			_path = path;
			//_tempFilename = $"{Path.GetFileNameWithoutExtension(filename)}.wav";
			_tempFilename = $"{(path + filename)}.wav";
			Console.WriteLine(path + _tempFilename);
			_waveSource = new WaveInEvent
			{
				WaveFormat = new WaveFormat(44100, 1)
			};

			_waveSource.DataAvailable += DataAvailable;
			_waveSource.RecordingStopped += RecordingStopped;
			_waveWriter = new WaveFileWriter(_tempFilename, _waveSource.WaveFormat);

			/*Начать запись аудио*/
			_waveSource.StartRecording();

		}

		/// <summary>
		/// Стоп записи
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void StopRecording()
		{			
			/*Остановить аудиозапись*/
			_waveSource.StopRecording();
		}

		/// <summary>
		/// Обратный вызов выполняется, когда запись остановлена
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RecordingStopped(object sender, StoppedEventArgs e)
		{			
			_waveSource.DataAvailable -= DataAvailable;
			_waveSource.RecordingStopped -= RecordingStopped;
			_waveSource?.Dispose();
			_waveWriter?.Dispose();

			/*Конвертируйте записанный файл в MP3*/
			ConvertWaveToMp3(_tempFilename, _path + _filename + ".mp3");

			/*Отправить уведомление о завершении записи*/
		//	RecordingFinished?.Invoke(this, null);
		}

		/// <summary>
		/// Обратный вызов выполняется, когда доступны новые данные
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DataAvailable(object sender, WaveInEventArgs e)
		{
			if (_waveWriter != null)
			{
				_waveWriter.Write(e.Buffer, 0, e.BytesRecorded);
				_waveWriter.Flush();
			}
		}

		/// <summary>
		/// Преобразует записанный файл WAV в MP3.
		/// </summary>
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

	}
}
