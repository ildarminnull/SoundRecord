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

namespace SoundRecord
{
	public partial class Setting : Form
	{
		public Setting()
		{
			InitializeComponent();
			//string Path = Settings.Default["Path"];
			Console.WriteLine("Test");
			Console.WriteLine(Settings.Default["Path"]);
			textBoxPath.Text = (string)(Settings.Default["Path"]);
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
			Settings.Default.Save(); //сохраняем новые значения
		}
	}
}
