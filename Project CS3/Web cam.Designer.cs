namespace Project_CS3
{
	partial class panelWeb_camModule
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnCapture = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.imgCapture = new System.Windows.Forms.PictureBox();
			this.imgBoxVDO = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.panelWebcam = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgCapture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgBoxVDO)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
			this.panelWebcam.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnClose);
			this.groupBox1.Controls.Add(this.btnSave);
			this.groupBox1.Controls.Add(this.btnCapture);
			this.groupBox1.Controls.Add(this.btnStop);
			this.groupBox1.Controls.Add(this.btnStart);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(425, 72);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(885, 113);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "VDO From WebCam";
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.HotPink;
			this.btnSave.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Image = global::Project_CS3.Properties.Resources.save_to_drive;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(529, 35);
			this.btnSave.Name = "btnSave";
			this.btnSave.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
			this.btnSave.Size = new System.Drawing.Size(152, 57);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Save";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Teal;
			this.groupBox2.Controls.Add(this.imgCapture);
			this.groupBox2.Controls.Add(this.imgBoxVDO);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.groupBox2.Location = new System.Drawing.Point(316, 200);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1113, 593);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "VDO Preview";
			// 
			// btnCapture
			// 
			this.btnCapture.BackColor = System.Drawing.Color.HotPink;
			this.btnCapture.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCapture.Image = global::Project_CS3.Properties.Resources.screenshot;
			this.btnCapture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCapture.Location = new System.Drawing.Point(338, 36);
			this.btnCapture.Name = "btnCapture";
			this.btnCapture.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnCapture.Size = new System.Drawing.Size(167, 57);
			this.btnCapture.TabIndex = 4;
			this.btnCapture.Text = "Capture";
			this.btnCapture.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCapture.UseVisualStyleBackColor = false;
			this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
			// 
			// btnStop
			// 
			this.btnStop.BackColor = System.Drawing.Color.HotPink;
			this.btnStop.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStop.Image = global::Project_CS3.Properties.Resources.stop_button;
			this.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnStop.Location = new System.Drawing.Point(173, 35);
			this.btnStop.Name = "btnStop";
			this.btnStop.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnStop.Size = new System.Drawing.Size(145, 57);
			this.btnStop.TabIndex = 1;
			this.btnStop.Text = "Stop";
			this.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnStop.UseVisualStyleBackColor = false;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.Color.HotPink;
			this.btnStart.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.Image = global::Project_CS3.Properties.Resources.play;
			this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnStart.Location = new System.Drawing.Point(16, 35);
			this.btnStart.Name = "btnStart";
			this.btnStart.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnStart.Size = new System.Drawing.Size(137, 57);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start";
			this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// imgCapture
			// 
			this.imgCapture.Location = new System.Drawing.Point(546, 28);
			this.imgCapture.Name = "imgCapture";
			this.imgCapture.Size = new System.Drawing.Size(562, 558);
			this.imgCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgCapture.TabIndex = 1;
			this.imgCapture.TabStop = false;
			// 
			// imgBoxVDO
			// 
			this.imgBoxVDO.Location = new System.Drawing.Point(6, 28);
			this.imgBoxVDO.Name = "imgBoxVDO";
			this.imgBoxVDO.Size = new System.Drawing.Size(537, 559);
			this.imgBoxVDO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgBoxVDO.TabIndex = 0;
			this.imgBoxVDO.TabStop = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Image = global::Project_CS3.Properties.Resources.filter;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(1511, 139);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(131, 46);
			this.button2.TabIndex = 106;
			this.button2.Text = "Filters";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::Project_CS3.Properties.Resources.picf3;
			this.pictureBox4.Location = new System.Drawing.Point(6, 46);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(94, 55);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 107;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
			// 
			// pictureBox15
			// 
			this.pictureBox15.Image = global::Project_CS3.Properties.Resources.picB1;
			this.pictureBox15.Location = new System.Drawing.Point(6, 141);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(94, 55);
			this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox15.TabIndex = 108;
			this.pictureBox15.TabStop = false;
			this.pictureBox15.Click += new System.EventHandler(this.pictureBox15_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(9, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 22);
			this.label6.TabIndex = 109;
			this.label6.Text = "Gray";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(9, 109);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(63, 22);
			this.label10.TabIndex = 110;
			this.label10.Text = "Binary";
			// 
			// panelWebcam
			// 
			this.panelWebcam.Controls.Add(this.label6);
			this.panelWebcam.Controls.Add(this.label10);
			this.panelWebcam.Controls.Add(this.pictureBox4);
			this.panelWebcam.Controls.Add(this.pictureBox15);
			this.panelWebcam.Location = new System.Drawing.Point(1523, 188);
			this.panelWebcam.Name = "panelWebcam";
			this.panelWebcam.Size = new System.Drawing.Size(110, 209);
			this.panelWebcam.TabIndex = 111;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.HotPink;
			this.btnClose.Image = global::Project_CS3.Properties.Resources.door_open__1_;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(704, 35);
			this.btnClose.Name = "btnClose";
			this.btnClose.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnClose.Size = new System.Drawing.Size(167, 60);
			this.btnClose.TabIndex = 112;
			this.btnClose.Text = "Exit";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// panelWeb_camModule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Yellow;
			this.ClientSize = new System.Drawing.Size(1729, 929);
			this.Controls.Add(this.panelWebcam);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "panelWeb_camModule";
			this.Text = "Web_cam";
			this.Load += new System.EventHandler(this.Web_cam_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imgCapture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgBoxVDO)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
			this.panelWebcam.ResumeLayout(false);
			this.panelWebcam.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCapture;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.PictureBox imgCapture;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.PictureBox imgBoxVDO;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Panel panelWebcam;
		private System.Windows.Forms.Button btnClose;
	}
}