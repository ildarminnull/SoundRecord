using NAudio.CoreAudioApi;
using SoundRecord.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoundRecord
{
	public partial class Setting : Form
	{
		string channel = "";
		int channelID;

		public Setting()
		{
			InitializeComponent();
			MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
			var devices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
			comboBoxChannel.Items.AddRange(devices.ToArray());
			textBoxPath.Text = (string)(Settings.Default["Path"]);
			channel = comboBoxChannel.Text;
			comboBoxChannel.SelectedIndex = (int)(Settings.Default["ChannelID"]);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				textBoxPath.Text = folderBrowserDialog1.SelectedPath;
			}
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{			
			Settings.Default["Path"] = textBoxPath.Text;
			Settings.Default["ChannelID"] = channelID;
			Settings.Default.Save(); //сохраняем новые значения
			labelSave.Text = "Настройки сохранены\n " +
				"Для применения настроек перезапустите программу";
		}

		private void comboBoxChannel_SelectedIndexChanged(object sender, EventArgs e)
		{
///			channel = comboBoxChannel.Text;
			channelID = comboBoxChannel.SelectedIndex;
		}
	}
}
