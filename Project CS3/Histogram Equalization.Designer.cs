namespace Project_CS3
{
	partial class Histogram_Equalization
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
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.radioBgr = new System.Windows.Forms.RadioButton();
			this.radioGray = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.txtksize = new System.Windows.Forms.TextBox();
			this.htgAfterE = new Emgu.CV.UI.HistogramBox();
			this.htgBeforeE = new Emgu.CV.UI.HistogramBox();
			this.label1 = new System.Windows.Forms.Label();
			this.htgGray = new Emgu.CV.UI.HistogramBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panelSubHisgram = new System.Windows.Forms.Panel();
			this.btnsubBinary = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.imgBoxInput = new Emgu.CV.UI.ImageBox();
			this.imgBoxGray = new Emgu.CV.UI.ImageBox();
			this.ImgBoxOutput = new Emgu.CV.UI.ImageBox();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panelSubHisgram.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgBoxInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgBoxGray)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBoxOutput)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.radioBgr);
			this.groupBox1.Controls.Add(this.radioGray);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtksize);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(29, 127);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 171);
			this.groupBox1.TabIndex = 61;
			this.groupBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(15, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(174, 22);
			this.label3.TabIndex = 109;
			this.label3.Text = "Please choose Noise";
			// 
			// radioBgr
			// 
			this.radioBgr.AutoSize = true;
			this.radioBgr.Location = new System.Drawing.Point(35, 49);
			this.radioBgr.Name = "radioBgr";
			this.radioBgr.Size = new System.Drawing.Size(52, 22);
			this.radioBgr.TabIndex = 29;
			this.radioBgr.TabStop = true;
			this.radioBgr.Text = "Bgr";
			this.radioBgr.UseVisualStyleBackColor = true;
			this.radioBgr.CheckedChanged += new System.EventHandler(this.radioBgr_CheckedChanged);
			// 
			// radioGray
			// 
			this.radioGray.AutoSize = true;
			this.radioGray.Location = new System.Drawing.Point(106, 50);
			this.radioGray.Name = "radioGray";
			this.radioGray.Size = new System.Drawing.Size(61, 22);
			this.radioGray.TabIndex = 30;
			this.radioGray.TabStop = true;
			this.radioGray.Text = "Gray";
			this.radioGray.UseVisualStyleBackColor = true;
			this.radioGray.CheckedChanged += new System.EventHandler(this.radioGray_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(21, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 22);
			this.label2.TabIndex = 103;
			this.label2.Text = "Ksize:";
			// 
			// txtksize
			// 
			this.txtksize.Location = new System.Drawing.Point(25, 131);
			this.txtksize.Name = "txtksize";
			this.txtksize.Size = new System.Drawing.Size(92, 24);
			this.txtksize.TabIndex = 60;
			this.txtksize.Text = "7";
			// 
			// htgAfterE
			// 
			this.htgAfterE.Location = new System.Drawing.Point(982, 358);
			this.htgAfterE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.htgAfterE.Name = "htgAfterE";
			this.htgAfterE.Size = new System.Drawing.Size(483, 305);
			this.htgAfterE.TabIndex = 58;
			// 
			// htgBeforeE
			// 
			this.htgBeforeE.Location = new System.Drawing.Point(6, 358);
			this.htgBeforeE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.htgBeforeE.Name = "htgBeforeE";
			this.htgBeforeE.Size = new System.Drawing.Size(483, 305);
			this.htgBeforeE.TabIndex = 48;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(962, 520);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 17);
			this.label1.TabIndex = 59;
			this.label1.Text = "Ksize:";
			// 
			// htgGray
			// 
			this.htgGray.Location = new System.Drawing.Point(494, 358);
			this.htgGray.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.htgGray.Name = "htgGray";
			this.htgGray.Size = new System.Drawing.Size(483, 305);
			this.htgGray.TabIndex = 49;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.imgBoxInput);
			this.panel1.Controls.Add(this.imgBoxGray);
			this.panel1.Controls.Add(this.htgAfterE);
			this.panel1.Controls.Add(this.ImgBoxOutput);
			this.panel1.Controls.Add(this.htgBeforeE);
			this.panel1.Controls.Add(this.htgGray);
			this.panel1.Location = new System.Drawing.Point(26, 95);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1471, 667);
			this.panel1.TabIndex = 62;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(40, 420);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(119, 22);
			this.label6.TabIndex = 103;
			this.label6.Text = "Median Filter";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(35, 319);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(131, 22);
			this.label5.TabIndex = 103;
			this.label5.Text = "Guassian Filter";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(33, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(196, 22);
			this.label4.TabIndex = 103;
			this.label4.Text = "Histogram Equalization";
			// 
			// panelSubHisgram
			// 
			this.panelSubHisgram.Controls.Add(this.pictureBox15);
			this.panelSubHisgram.Controls.Add(this.pictureBox3);
			this.panelSubHisgram.Controls.Add(this.pictureBox4);
			this.panelSubHisgram.Controls.Add(this.label6);
			this.panelSubHisgram.Controls.Add(this.label5);
			this.panelSubHisgram.Controls.Add(this.label4);
			this.panelSubHisgram.Controls.Add(this.groupBox1);
			this.panelSubHisgram.Location = new System.Drawing.Point(1505, 95);
			this.panelSubHisgram.Name = "panelSubHisgram";
			this.panelSubHisgram.Size = new System.Drawing.Size(263, 550);
			this.panelSubHisgram.TabIndex = 105;
			// 
			// btnsubBinary
			// 
			this.btnsubBinary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnsubBinary.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsubBinary.Image = global::Project_CS3.Properties.Resources.chart_curve;
			this.btnsubBinary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnsubBinary.Location = new System.Drawing.Point(1534, 23);
			this.btnsubBinary.Name = "btnsubBinary";
			this.btnsubBinary.Size = new System.Drawing.Size(172, 53);
			this.btnsubBinary.TabIndex = 111;
			this.btnsubBinary.Text = "Histogram";
			this.btnsubBinary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnsubBinary.UseVisualStyleBackColor = false;
			this.btnsubBinary.Click += new System.EventHandler(this.btnsubBinary_Click);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.HotPink;
			this.btnClose.Image = global::Project_CS3.Properties.Resources.door_open__1_;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(817, 813);
			this.btnClose.Name = "btnClose";
			this.btnClose.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnClose.Size = new System.Drawing.Size(167, 60);
			this.btnClose.TabIndex = 106;
			this.btnClose.Text = "Exit";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.HotPink;
			this.btnSave.Image = global::Project_CS3.Properties.Resources.save_to_drive;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(585, 813);
			this.btnSave.Name = "btnSave";
			this.btnSave.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnSave.Size = new System.Drawing.Size(167, 60);
			this.btnSave.TabIndex = 107;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnOpen
			// 
			this.btnOpen.BackColor = System.Drawing.Color.HotPink;
			this.btnOpen.Image = global::Project_CS3.Properties.Resources.drag_and_drop;
			this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOpen.Location = new System.Drawing.Point(358, 813);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnOpen.Size = new System.Drawing.Size(167, 60);
			this.btnOpen.TabIndex = 108;
			this.btnOpen.Text = "Open";
			this.btnOpen.UseVisualStyleBackColor = false;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// pictureBox15
			// 
			this.pictureBox15.Image = global::Project_CS3.Properties.Resources.picH1;
			this.pictureBox15.Location = new System.Drawing.Point(29, 48);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(94, 55);
			this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox15.TabIndex = 100;
			this.pictureBox15.TabStop = false;
			this.pictureBox15.Click += new System.EventHandler(this.pictureBox15_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::Project_CS3.Properties.Resources.picHB2;
			this.pictureBox3.Location = new System.Drawing.Point(36, 353);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(94, 55);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 100;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::Project_CS3.Properties.Resources.picHB3;
			this.pictureBox4.Location = new System.Drawing.Point(36, 457);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(94, 55);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 100;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
			// 
			// imgBoxInput
			// 
			this.imgBoxInput.Location = new System.Drawing.Point(6, 5);
			this.imgBoxInput.Name = "imgBoxInput";
			this.imgBoxInput.Size = new System.Drawing.Size(483, 346);
			this.imgBoxInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgBoxInput.TabIndex = 47;
			this.imgBoxInput.TabStop = false;
			// 
			// imgBoxGray
			// 
			this.imgBoxGray.Location = new System.Drawing.Point(494, 5);
			this.imgBoxGray.Name = "imgBoxGray";
			this.imgBoxGray.Size = new System.Drawing.Size(483, 346);
			this.imgBoxGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgBoxGray.TabIndex = 57;
			this.imgBoxGray.TabStop = false;
			// 
			// ImgBoxOutput
			// 
			this.ImgBoxOutput.Location = new System.Drawing.Point(982, 5);
			this.ImgBoxOutput.Name = "ImgBoxOutput";
			this.ImgBoxOutput.Size = new System.Drawing.Size(483, 346);
			this.ImgBoxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImgBoxOutput.TabIndex = 50;
			this.ImgBoxOutput.TabStop = false;
			// 
			// Histogram_Equalization
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Yellow;
			this.ClientSize = new System.Drawing.Size(1895, 972);
			this.Controls.Add(this.btnsubBinary);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.panelSubHisgram);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Histogram_Equalization";
			this.Text = "Histogram";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panelSubHisgram.ResumeLayout(false);
			this.panelSubHisgram.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgBoxInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgBoxGray)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBoxOutput)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioBgr;
		private System.Windows.Forms.RadioButton radioGray;
		private Emgu.CV.UI.HistogramBox htgAfterE;
		private Emgu.CV.UI.ImageBox imgBoxGray;
		private Emgu.CV.UI.HistogramBox htgBeforeE;
		private System.Windows.Forms.TextBox txtksize;
		private System.Windows.Forms.Label label1;
		private Emgu.CV.UI.ImageBox ImgBoxOutput;
		private Emgu.CV.UI.HistogramBox htgGray;
		private Emgu.CV.UI.ImageBox imgBoxInput;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panelSubHisgram;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnsubBinary;
	}
}