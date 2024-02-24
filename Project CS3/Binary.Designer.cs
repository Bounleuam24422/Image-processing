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
			this.btnBinary = new System.Windows.Forms.Button();
			this.btnMean = new System.Windows.Forms.Button();
			this.btnOT_Su = new System.Windows.Forms.Button();
			this.btnGuasian = new System.Windows.Forms.Button();
			this.btnBiny_Inver = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.imgGray = new Emgu.CV.UI.ImageBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.imgInput = new Emgu.CV.UI.ImageBox();
			this.imgBinary = new Emgu.CV.UI.ImageBox();
			this.btnCrop = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgGray)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgBinary)).BeginInit();
			this.SuspendLayout();
			// 
			// btnBinary
			// 
			this.btnBinary.BackColor = System.Drawing.Color.SandyBrown;
			this.btnBinary.Location = new System.Drawing.Point(1172, 94);
			this.btnBinary.Name = "btnBinary";
			this.btnBinary.Size = new System.Drawing.Size(154, 45);
			this.btnBinary.TabIndex = 91;
			this.btnBinary.Text = "Binary";
			this.btnBinary.UseVisualStyleBackColor = false;
			this.btnBinary.Click += new System.EventHandler(this.btnBinary_Click);
			// 
			// btnMean
			// 
			this.btnMean.BackColor = System.Drawing.Color.SandyBrown;
			this.btnMean.Location = new System.Drawing.Point(1172, 355);
			this.btnMean.Name = "btnMean";
			this.btnMean.Size = new System.Drawing.Size(154, 45);
			this.btnMean.TabIndex = 90;
			this.btnMean.Text = "Mean";
			this.btnMean.UseVisualStyleBackColor = false;
			this.btnMean.Click += new System.EventHandler(this.btnMean_Click);
			// 
			// btnOT_Su
			// 
			this.btnOT_Su.BackColor = System.Drawing.Color.SandyBrown;
			this.btnOT_Su.Location = new System.Drawing.Point(1172, 223);
			this.btnOT_Su.Name = "btnOT_Su";
			this.btnOT_Su.Size = new System.Drawing.Size(154, 45);
			this.btnOT_Su.TabIndex = 89;
			this.btnOT_Su.Text = "OT\'Su";
			this.btnOT_Su.UseVisualStyleBackColor = false;
			this.btnOT_Su.Click += new System.EventHandler(this.btnOT_Su_Click);
			// 
			// btnGuasian
			// 
			this.btnGuasian.BackColor = System.Drawing.Color.SandyBrown;
			this.btnGuasian.Location = new System.Drawing.Point(1172, 287);
			this.btnGuasian.Name = "btnGuasian";
			this.btnGuasian.Size = new System.Drawing.Size(154, 45);
			this.btnGuasian.TabIndex = 88;
			this.btnGuasian.Text = "Guasian";
			this.btnGuasian.UseVisualStyleBackColor = false;
			this.btnGuasian.Click += new System.EventHandler(this.btnGuasian_Click);
			// 
			// btnBiny_Inver
			// 
			this.btnBiny_Inver.BackColor = System.Drawing.Color.SandyBrown;
			this.btnBiny_Inver.Location = new System.Drawing.Point(1172, 159);
			this.btnBiny_Inver.Name = "btnBiny_Inver";
			this.btnBiny_Inver.Size = new System.Drawing.Size(154, 45);
			this.btnBiny_Inver.TabIndex = 87;
			this.btnBiny_Inver.Text = "Binary Inver";
			this.btnBiny_Inver.UseVisualStyleBackColor = false;
			this.btnBiny_Inver.Click += new System.EventHandler(this.btnBiny_Inver_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.panel1.Controls.Add(this.imgInput);
			this.panel1.Controls.Add(this.imgBinary);
			this.panel1.Location = new System.Drawing.Point(40, 31);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1091, 468);
			this.panel1.TabIndex = 100;
			// 
			// imgGray
			// 
			this.imgGray.Location = new System.Drawing.Point(1523, 586);
			this.imgGray.Name = "imgGray";
			this.imgGray.Size = new System.Drawing.Size(10, 10);
			this.imgGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgGray.TabIndex = 15;
			this.imgGray.TabStop = false;
			this.imgGray.Visible = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::Project_CS3.Properties.Resources.picB5;
			this.pictureBox4.Location = new System.Drawing.Point(1352, 355);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(67, 45);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 99;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::Project_CS3.Properties.Resources.picB4;
			this.pictureBox3.Location = new System.Drawing.Point(1352, 287);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(67, 45);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 99;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Project_CS3.Properties.Resources.picB3;
			this.pictureBox2.Location = new System.Drawing.Point(1352, 222);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(67, 45);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 99;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Project_CS3.Properties.Resources.picB2;
			this.pictureBox1.Location = new System.Drawing.Point(1352, 159);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(67, 45);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 99;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox15
			// 
			this.pictureBox15.Image = global::Project_CS3.Properties.Resources.picB1;
			this.pictureBox15.Location = new System.Drawing.Point(1352, 94);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(67, 45);
			this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox15.TabIndex = 99;
			this.pictureBox15.TabStop = false;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.HotPink;
			this.btnClose.Image = global::Project_CS3.Properties.Resources.door_open__1_;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(643, 586);
			this.btnClose.Name = "btnClose";
			this.btnClose.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnClose.Size = new System.Drawing.Size(154, 45);
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
			this.btnSave.Location = new System.Drawing.Point(448, 586);
			this.btnSave.Name = "btnSave";
			this.btnSave.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnSave.Size = new System.Drawing.Size(154, 45);
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
			this.btnOpen.Location = new System.Drawing.Point(258, 586);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnOpen.Size = new System.Drawing.Size(154, 45);
			this.btnOpen.TabIndex = 20;
			this.btnOpen.Text = "Open";
			this.btnOpen.UseVisualStyleBackColor = false;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// imgInput
			// 
			this.imgInput.Location = new System.Drawing.Point(5, 3);
			this.imgInput.Name = "imgInput";
			this.imgInput.Size = new System.Drawing.Size(537, 460);
			this.imgInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgInput.TabIndex = 14;
			this.imgInput.TabStop = false;
			// 
			// imgBinary
			// 
			this.imgBinary.Location = new System.Drawing.Point(549, 4);
			this.imgBinary.Name = "imgBinary";
			this.imgBinary.Size = new System.Drawing.Size(537, 460);
			this.imgBinary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgBinary.TabIndex = 13;
			this.imgBinary.TabStop = false;
			// 
			// btnCrop
			// 
			this.btnCrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnCrop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCrop.ForeColor = System.Drawing.Color.Black;
			this.btnCrop.Location = new System.Drawing.Point(683, 314);
			this.btnCrop.Margin = new System.Windows.Forms.Padding(4);
			this.btnCrop.Name = "btnCrop";
			this.btnCrop.Size = new System.Drawing.Size(167, 60);
			this.btnCrop.TabIndex = 102;
			this.btnCrop.Text = "Crop";
			this.btnCrop.UseVisualStyleBackColor = false;
			// 
			// BinaryModule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Yellow;
			this.ClientSize = new System.Drawing.Size(1532, 689);
			this.Controls.Add(this.btnCrop);
			this.Controls.Add(this.imgGray);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox15);
			this.Controls.Add(this.btnBinary);
			this.Controls.Add(this.btnMean);
			this.Controls.Add(this.btnOT_Su);
			this.Controls.Add(this.btnGuasian);
			this.Controls.Add(this.btnBiny_Inver);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "BinaryModule";
			this.Text = "Binary";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imgGray)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgBinary)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Emgu.CV.UI.ImageBox imgBinary;
		private Emgu.CV.UI.ImageBox imgInput;
		private Emgu.CV.UI.ImageBox imgGray;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnBinary;
		private System.Windows.Forms.Button btnMean;
		private System.Windows.Forms.Button btnOT_Su;
		private System.Windows.Forms.Button btnGuasian;
		private System.Windows.Forms.Button btnBiny_Inver;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnCrop;
	}
}