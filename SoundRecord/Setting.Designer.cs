namespace SoundRecord
{
	partial class Setting
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxPath = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.buttonSave = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxChannel = new System.Windows.Forms.ComboBox();
			this.labelSave = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Путь сохранения файлов";
			// 
			// textBoxPath
			// 
			this.textBoxPath.Location = new System.Drawing.Point(17, 34);
			this.textBoxPath.Name = "textBoxPath";
			this.textBoxPath.Size = new System.Drawing.Size(202, 20);
			this.textBoxPath.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(225, 28);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(33, 27);
			this.button1.TabIndex = 2;
			this.button1.Text = "...";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonSave.Location = new System.Drawing.Point(17, 133);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 3;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = false;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(13, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 19);
			this.label2.TabIndex = 5;
			this.label2.Text = "Звуковой канал";
			// 
			// comboBoxChannel
			// 
			this.comboBoxChannel.FormattingEnabled = true;
			this.comboBoxChannel.Location = new System.Drawing.Point(17, 87);
			this.comboBoxChannel.Name = "comboBoxChannel";
			this.comboBoxChannel.Size = new System.Drawing.Size(310, 21);
			this.comboBoxChannel.TabIndex = 6;
			this.comboBoxChannel.SelectedIndexChanged += new System.EventHandler(this.comboBoxChannel_SelectedIndexChanged);
			// 
			// labelSave
			// 
			this.labelSave.AutoSize = true;
			this.labelSave.Location = new System.Drawing.Point(17, 163);
			this.labelSave.Name = "labelSave";
			this.labelSave.Size = new System.Drawing.Size(0, 13);
			this.labelSave.TabIndex = 7;
			this.labelSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Setting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 325);
			this.Controls.Add(this.labelSave);
			this.Controls.Add(this.comboBoxChannel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBoxPath);
			this.Controls.Add(this.label1);
			this.Name = "Setting";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "Setting";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxPath;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxChannel;
		private System.Windows.Forms.Label labelSave;
	}
}