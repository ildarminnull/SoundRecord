namespace SoundRecord
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bStop = new System.Windows.Forms.Button();
			this.bRec = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1Path = new System.Windows.Forms.TextBox();
			this.textBoxLog = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.progressBar2 = new ExtendedDotNET.Controls.Progress.ProgressBar();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 10;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 157);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 26);
			this.label1.TabIndex = 4;
			this.label1.Text = "Record:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(421, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// settingToolStripMenuItem
			// 
			this.settingToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
			this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.settingToolStripMenuItem.Text = "Setting";
			this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
			// 
			// bStop
			// 
			this.bStop.Image = global::SoundRecord.Properties.Resources.Stop24;
			this.bStop.Location = new System.Drawing.Point(155, 153);
			this.bStop.Name = "bStop";
			this.bStop.Size = new System.Drawing.Size(28, 30);
			this.bStop.TabIndex = 3;
			this.bStop.UseVisualStyleBackColor = true;
			this.bStop.Click += new System.EventHandler(this.bStop_Click);
			// 
			// bRec
			// 
			this.bRec.BackgroundImage = global::SoundRecord.Properties.Resources.Rec24;
			this.bRec.Image = global::SoundRecord.Properties.Resources.Rec24;
			this.bRec.Location = new System.Drawing.Point(121, 154);
			this.bRec.Name = "bRec";
			this.bRec.Size = new System.Drawing.Size(28, 29);
			this.bRec.TabIndex = 2;
			this.bRec.UseVisualStyleBackColor = true;
			this.bRec.Click += new System.EventHandler(this.bRec_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Звуковой канал";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Индикация звука";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 213);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(137, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Путь сохранения файлов:";
			// 
			// textBox1Path
			// 
			this.textBox1Path.Location = new System.Drawing.Point(155, 210);
			this.textBox1Path.Name = "textBox1Path";
			this.textBox1Path.Size = new System.Drawing.Size(254, 20);
			this.textBox1Path.TabIndex = 9;
			// 
			// textBoxLog
			// 
			this.textBoxLog.Location = new System.Drawing.Point(23, 273);
			this.textBoxLog.Name = "textBoxLog";
			this.textBoxLog.Size = new System.Drawing.Size(386, 20);
			this.textBoxLog.TabIndex = 10;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// progressBar2
			// 
			this.progressBar2.BarOffset = 1;
			this.progressBar2.Caption = "Progress";
			this.progressBar2.CaptionColor = System.Drawing.Color.Black;
			this.progressBar2.CaptionMode = ExtendedDotNET.Controls.Progress.ProgressCaptionMode.Percent;
			this.progressBar2.CaptionShadowColor = System.Drawing.Color.White;
			this.progressBar2.ChangeByMouse = false;
			this.progressBar2.DashSpace = 2;
			this.progressBar2.DashWidth = 5;
			this.progressBar2.Edge = ExtendedDotNET.Controls.Progress.ProgressBarEdge.Rounded;
			this.progressBar2.EdgeColor = System.Drawing.Color.Gray;
			this.progressBar2.EdgeLightColor = System.Drawing.Color.LightGray;
			this.progressBar2.EdgeWidth = 1;
			this.progressBar2.FloodPercentage = 0.2F;
			this.progressBar2.FloodStyle = ExtendedDotNET.Controls.Progress.ProgressFloodStyle.Standard;
			this.progressBar2.Invert = false;
			this.progressBar2.Location = new System.Drawing.Point(20, 113);
			this.progressBar2.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
			this.progressBar2.Maximum = 100;
			this.progressBar2.Minimum = 0;
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Orientation = ExtendedDotNET.Controls.Progress.ProgressBarDirection.Horizontal;
			this.progressBar2.ProgressBackColor = System.Drawing.Color.White;
			this.progressBar2.ProgressBarStyle = ExtendedDotNET.Controls.Progress.ProgressStyle.Dashed;
			this.progressBar2.SecondColor = System.Drawing.Color.White;
			this.progressBar2.Shadow = true;
			this.progressBar2.ShadowOffset = 1;
			this.progressBar2.Size = new System.Drawing.Size(384, 24);
			this.progressBar2.Step = 1;
			this.progressBar2.TabIndex = 11;
			this.progressBar2.TextAntialias = true;
			this.progressBar2.Value = 33;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(20, 47);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(384, 21);
			this.comboBox1.TabIndex = 13;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(421, 450);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.progressBar2);
			this.Controls.Add(this.textBoxLog);
			this.Controls.Add(this.textBox1Path);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bStop);
			this.Controls.Add(this.bRec);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Button bRec;
		private System.Windows.Forms.Button bStop;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1Path;
		private System.Windows.Forms.TextBox textBoxLog;
		private System.Windows.Forms.Timer timer1;
		private ExtendedDotNET.Controls.Progress.ProgressBar progressBar2;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}

