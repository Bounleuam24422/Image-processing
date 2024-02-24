namespace Project_CS3
{
	partial class Edge_Detection
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
			this.imgInput = new Emgu.CV.UI.ImageBox();
			this.imgOutput = new Emgu.CV.UI.ImageBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnsubBinary = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.imgInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgOutput)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// imgInput
			// 
			this.imgInput.Location = new System.Drawing.Point(3, 3);
			this.imgInput.Name = "imgInput";
			this.imgInput.Size = new System.Drawing.Size(551, 569);
			this.imgInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgInput.TabIndex = 8;
			this.imgInput.TabStop = false;
			// 
			// imgOutput
			// 
			this.imgOutput.Location = new System.Drawing.Point(557, 3);
			this.imgOutput.Name = "imgOutput";
			this.imgOutput.Size = new System.Drawing.Size(554, 569);
			this.imgOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgOutput.TabIndex = 9;
			this.imgOutput.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.imgOutput);
			this.panel1.Controls.Add(this.imgInput);
			this.panel1.Location = new System.Drawing.Point(56, 138);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1114, 575);
			this.panel1.TabIndex = 10;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.HotPink;
			this.btnClose.Image = global::Project_CS3.Properties.Resources.door_open__1_;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(689, 787);
			this.btnClose.Name = "btnClose";
			this.btnClose.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnClose.Size = new System.Drawing.Size(167, 60);
			this.btnClose.TabIndex = 21;
			this.btnClose.Text = "Exit";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.HotPink;
			this.btnSave.Image = global::Project_CS3.Properties.Resources.save_to_drive;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(457, 787);
			this.btnSave.Name = "btnSave";
			this.btnSave.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnSave.Size = new System.Drawing.Size(167, 60);
			this.btnSave.TabIndex = 22;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnOpen
			// 
			this.btnOpen.BackColor = System.Drawing.Color.HotPink;
			this.btnOpen.Image = global::Project_CS3.Properties.Resources.drag_and_drop;
			this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOpen.Location = new System.Drawing.Point(230, 787);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnOpen.Size = new System.Drawing.Size(167, 60);
			this.btnOpen.TabIndex = 23;
			this.btnOpen.Text = "Open";
			this.btnOpen.UseVisualStyleBackColor = false;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(131, 79);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(63, 22);
			this.label10.TabIndex = 116;
			this.label10.Text = "Binary";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(132, 184);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 22);
			this.label2.TabIndex = 114;
			this.label2.Text = "Binary Invert";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(134, 288);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(60, 22);
			this.label12.TabIndex = 115;
			this.label12.Text = "OT\'Su";
			// 
			// pictureBox15
			// 
			this.pictureBox15.Image = global::Project_CS3.Properties.Resources.picB1;
			this.pictureBox15.Location = new System.Drawing.Point(130, 115);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(94, 55);
			this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox15.TabIndex = 111;
			this.pictureBox15.TabStop = false;
			this.pictureBox15.Click += new System.EventHandler(this.pictureBox15_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Project_CS3.Properties.Resources.picB2;
			this.pictureBox1.Location = new System.Drawing.Point(130, 218);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(94, 55);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 112;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Project_CS3.Properties.Resources.picB3;
			this.pictureBox2.Location = new System.Drawing.Point(134, 323);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(94, 55);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 113;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// btnsubBinary
			// 
			this.btnsubBinary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnsubBinary.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsubBinary.Image = global::Project_CS3.Properties.Resources.file__1_1;
			this.btnsubBinary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnsubBinary.Location = new System.Drawing.Point(1310, 76);
			this.btnsubBinary.Name = "btnsubBinary";
			this.btnsubBinary.Size = new System.Drawing.Size(130, 46);
			this.btnsubBinary.TabIndex = 117;
			this.btnsubBinary.Text = "Binary";
			this.btnsubBinary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnsubBinary.UseVisualStyleBackColor = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pictureBox15);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Location = new System.Drawing.Point(1212, 141);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(417, 548);
			this.panel2.TabIndex = 118;
			// 
			// Edge_Detection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1729, 929);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btnsubBinary);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.panel1);
			this.Name = "Edge_Detection";
			this.Text = "Edge_Detection";
			((System.ComponentModel.ISupportInitialize)(this.imgInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgOutput)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Emgu.CV.UI.ImageBox imgInput;
		private Emgu.CV.UI.ImageBox imgOutput;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btnsubBinary;
		private System.Windows.Forms.Panel panel2;
	}
}