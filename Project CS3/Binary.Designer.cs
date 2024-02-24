namespace Project_CS3
{
	partial class BinaryModule
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.panelBimary = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnsubBinary = new System.Windows.Forms.Button();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.imgGray = new Emgu.CV.UI.ImageBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.imgInput = new Emgu.CV.UI.ImageBox();
			this.imgBinary = new Emgu.CV.UI.ImageBox();
			this.panel1.SuspendLayout();
			this.panelBimary.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgGray)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgBinary)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.imgInput);
			this.panel1.Controls.Add(this.imgBinary);
			this.panel1.Location = new System.Drawing.Point(63, 74);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1117, 575);
			this.panel1.TabIndex = 100;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(15, 209);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(60, 22);
			this.label12.TabIndex = 106;
			this.label12.Text = "OT\'Su";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(15, 319);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(82, 22);
			this.label11.TabIndex = 107;
			this.label11.Text = "Guassian";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(12, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(63, 22);
			this.label10.TabIndex = 108;
			this.label10.Text = "Binary";
			// 
			// panelBimary
			// 
			this.panelBimary.Controls.Add(this.label10);
			this.panelBimary.Controls.Add(this.label2);
			this.panelBimary.Controls.Add(this.label12);
			this.panelBimary.Controls.Add(this.pictureBox15);
			this.panelBimary.Controls.Add(this.label1);
			this.panelBimary.Controls.Add(this.label11);
			this.panelBimary.Controls.Add(this.pictureBox1);
			this.panelBimary.Controls.Add(this.pictureBox2);
			this.panelBimary.Controls.Add(this.pictureBox3);
			this.panelBimary.Controls.Add(this.pictureBox4);
			this.panelBimary.Location = new System.Drawing.Point(1313, 77);
			this.panelBimary.Name = "panelBimary";
			this.panelBimary.Size = new System.Drawing.Size(141, 559);
			this.panelBimary.TabIndex = 109;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 22);
			this.label2.TabIndex = 106;
			this.label2.Text = "Binary Invert";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 430);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 22);
			this.label1.TabIndex = 107;
			this.label1.Text = "Mean";
			// 
			// btnsubBinary
			// 
			this.btnsubBinary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnsubBinary.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsubBinary.Image = global::Project_CS3.Properties.Resources.file__1_1;
			this.btnsubBinary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnsubBinary.Location = new System.Drawing.Point(1323, 22);
			this.btnsubBinary.Name = "btnsubBinary";
			this.btnsubBinary.Size = new System.Drawing.Size(130, 46);
			this.btnsubBinary.TabIndex = 110;
			this.btnsubBinary.Text = "Binary";
			this.btnsubBinary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnsubBinary.UseVisualStyleBackColor = false;
			this.btnsubBinary.Click += new System.EventHandler(this.btnsubBinary_Click);
			// 
			// pictureBox15
			// 
			this.pictureBox15.Image = global::Project_CS3.Properties.Resources.picB1;
			this.pictureBox15.Location = new System.Drawing.Point(11, 36);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(94, 55);
			this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox15.TabIndex = 99;
			this.pictureBox15.TabStop = false;
			this.pictureBox15.Click += new System.EventHandler(this.pictureBox15_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Project_CS3.Properties.Resources.picB2;
			this.pictureBox1.Location = new System.Drawing.Point(11, 139);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(94, 55);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 99;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Project_CS3.Properties.Resources.picB3;
			this.pictureBox2.Location = new System.Drawing.Point(15, 244);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(94, 55);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 99;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::Project_CS3.Properties.Resources.picB4;
			this.pictureBox3.Location = new System.Drawing.Point(15, 358);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(94, 55);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 99;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::Project_CS3.Properties.Resources.picB5;
			this.pictureBox4.Location = new System.Drawing.Point(16, 472);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(94, 55);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 99;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
			// 
			// imgGray
			// 
			this.imgGray.Location = new System.Drawing.Point(1546, 624);
			this.imgGray.Name = "imgGray";
			this.imgGray.Size = new System.Drawing.Size(10, 10);
			this.imgGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgGray.TabIndex = 15;
			this.imgGray.TabStop = false;
			this.imgGray.Visible = false;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.HotPink;
			this.btnClose.Image = global::Project_CS3.Properties.Resources.door_open__1_;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(763, 679);
			this.btnClose.Name = "btnClose";
			this.btnClose.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnClose.Size = new System.Drawing.Size(167, 60);
			this.btnClose.TabIndex = 20;
			this.btnClose.Text = "Exit";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.HotPink;
			this.btnSave.Image = global::Project_CS3.Properties.Resources.save_to_drive;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(531, 679);
			this.btnSave.Name = "btnSave";
			this.btnSave.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnSave.Size = new System.Drawing.Size(167, 60);
			this.btnSave.TabIndex = 20;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnOpen
			// 
			this.btnOpen.BackColor = System.Drawing.Color.HotPink;
			this.btnOpen.Image = global::Project_CS3.Properties.Resources.drag_and_drop;
			this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOpen.Location = new System.Drawing.Point(304, 679);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnOpen.Size = new System.Drawing.Size(167, 60);
			this.btnOpen.TabIndex = 20;
			this.btnOpen.Text = "Open";
			this.btnOpen.UseVisualStyleBackColor = false;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// imgInput
			// 
			this.imgInput.Location = new System.Drawing.Point(4, 7);
			this.imgInput.Name = "imgInput";
			this.imgInput.Size = new System.Drawing.Size(537, 559);
			this.imgInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgInput.TabIndex = 14;
			this.imgInput.TabStop = false;
			// 
			// imgBinary
			// 
			this.imgBinary.Location = new System.Drawing.Point(548, 9);
			this.imgBinary.Name = "imgBinary";
			this.imgBinary.Size = new System.Drawing.Size(562, 558);
			this.imgBinary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgBinary.TabIndex = 13;
			this.imgBinary.TabStop = false;
			// 
			// BinaryModule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Yellow;
			this.ClientSize = new System.Drawing.Size(1532, 777);
			this.Controls.Add(this.btnsubBinary);
			this.Controls.Add(this.panelBimary);
			this.Controls.Add(this.imgGray);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "BinaryModule";
			this.Text = "Binary";
			this.panel1.ResumeLayout(false);
			this.panelBimary.ResumeLayout(false);
			this.panelBimary.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgGray)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgBinary)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Emgu.CV.UI.ImageBox imgBinary;
		private Emgu.CV.UI.ImageBox imgInput;
		private Emgu.CV.UI.ImageBox imgGray;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Panel panelBimary;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnsubBinary;
	}
}