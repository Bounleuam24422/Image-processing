﻿namespace Project_CS3
{
	partial class Web_cam
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCapture = new System.Windows.Forms.Button();
			this.btnBinary = new System.Windows.Forms.Button();
			this.btnGray = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.imgCapture = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.imgBoxVDO = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgCapture)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgBoxVDO)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSave);
			this.groupBox1.Controls.Add(this.btnCapture);
			this.groupBox1.Controls.Add(this.btnBinary);
			this.groupBox1.Controls.Add(this.btnGray);
			this.groupBox1.Controls.Add(this.btnStop);
			this.groupBox1.Controls.Add(this.btnStart);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(40, 21);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(707, 102);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "VDO From WebCam";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(578, 36);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(105, 39);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCapture
			// 
			this.btnCapture.Location = new System.Drawing.Point(467, 36);
			this.btnCapture.Name = "btnCapture";
			this.btnCapture.Size = new System.Drawing.Size(105, 39);
			this.btnCapture.TabIndex = 4;
			this.btnCapture.Text = "Capture";
			this.btnCapture.UseVisualStyleBackColor = true;
			this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
			// 
			// btnBinary
			// 
			this.btnBinary.Location = new System.Drawing.Point(356, 36);
			this.btnBinary.Name = "btnBinary";
			this.btnBinary.Size = new System.Drawing.Size(105, 39);
			this.btnBinary.TabIndex = 3;
			this.btnBinary.Text = "Binary";
			this.btnBinary.UseVisualStyleBackColor = true;
			this.btnBinary.Click += new System.EventHandler(this.btnBinary_Click);
			// 
			// btnGray
			// 
			this.btnGray.Location = new System.Drawing.Point(245, 36);
			this.btnGray.Name = "btnGray";
			this.btnGray.Size = new System.Drawing.Size(105, 39);
			this.btnGray.TabIndex = 2;
			this.btnGray.Text = "Gray";
			this.btnGray.UseVisualStyleBackColor = true;
			this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(134, 36);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(105, 39);
			this.btnStop.TabIndex = 1;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(23, 36);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(105, 39);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// imgCapture
			// 
			this.imgCapture.Location = new System.Drawing.Point(389, 71);
			this.imgCapture.Name = "imgCapture";
			this.imgCapture.Size = new System.Drawing.Size(327, 329);
			this.imgCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgCapture.TabIndex = 1;
			this.imgCapture.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.imgCapture);
			this.groupBox2.Controls.Add(this.imgBoxVDO);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(40, 129);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(794, 432);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "VDO Preview";
			// 
			// imgBoxVDO
			// 
			this.imgBoxVDO.Location = new System.Drawing.Point(23, 71);
			this.imgBoxVDO.Name = "imgBoxVDO";
			this.imgBoxVDO.Size = new System.Drawing.Size(327, 329);
			this.imgBoxVDO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgBoxVDO.TabIndex = 0;
			this.imgBoxVDO.TabStop = false;
			// 
			// Web_cam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(890, 599);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Name = "Web_cam";
			this.Text = "Web_cam";
			this.Load += new System.EventHandler(this.Web_cam_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imgCapture)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imgBoxVDO)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCapture;
		private System.Windows.Forms.Button btnBinary;
		private System.Windows.Forms.Button btnGray;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.PictureBox imgCapture;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.PictureBox imgBoxVDO;
	}
}