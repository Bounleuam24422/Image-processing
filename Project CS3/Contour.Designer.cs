namespace Project_CS3
{
	partial class ContourModule
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
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.imgOutput = new Emgu.CV.UI.ImageBox();
			this.imgInput = new Emgu.CV.UI.ImageBox();
			this.label10 = new System.Windows.Forms.Label();
			this.panelContour = new System.Windows.Forms.Panel();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.btnsubBinary = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgOutput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgInput)).BeginInit();
			this.panelContour.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.imgOutput);
			this.panel1.Controls.Add(this.imgInput);
			this.panel1.Location = new System.Drawing.Point(70, 82);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1117, 568);
			this.panel1.TabIndex = 11;
			// 
			// imgOutput
			// 
			this.imgOutput.Location = new System.Drawing.Point(547, 4);
			this.imgOutput.Name = "imgOutput";
			this.imgOutput.Size = new System.Drawing.Size(565, 558);
			this.imgOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgOutput.TabIndex = 8;
			this.imgOutput.TabStop = false;
			// 
			// imgInput
			// 
			this.imgInput.Location = new System.Drawing.Point(4, 3);
			this.imgInput.Name = "imgInput";
			this.imgInput.Size = new System.Drawing.Size(537, 559);
			this.imgInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgInput.TabIndex = 9;
			this.imgInput.TabStop = false;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(13, 4);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(114, 22);
			this.label10.TabIndex = 112;
			this.label10.Text = "Find Contour";
			// 
			// panelContour
			// 
			this.panelContour.Controls.Add(this.label10);
			this.panelContour.Controls.Add(this.pictureBox15);
			this.panelContour.Location = new System.Drawing.Point(1326, 91);
			this.panelContour.Name = "panelContour";
			this.panelContour.Size = new System.Drawing.Size(140, 108);
			this.panelContour.TabIndex = 114;
			// 
			// pictureBox15
			// 
			this.pictureBox15.Image = global::Project_CS3.Properties.Resources.De;
			this.pictureBox15.Location = new System.Drawing.Point(12, 40);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(94, 55);
			this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox15.TabIndex = 111;
			this.pictureBox15.TabStop = false;
			this.pictureBox15.Click += new System.EventHandler(this.pictureBox15_Click);
			// 
			// btnsubBinary
			// 
			this.btnsubBinary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnsubBinary.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsubBinary.Image = global::Project_CS3.Properties.Resources.contour_line;
			this.btnsubBinary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnsubBinary.Location = new System.Drawing.Point(1318, 26);
			this.btnsubBinary.Name = "btnsubBinary";
			this.btnsubBinary.Size = new System.Drawing.Size(167, 46);
			this.btnsubBinary.TabIndex = 113;
			this.btnsubBinary.Text = "Contour";
			this.btnsubBinary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnsubBinary.UseVisualStyleBackColor = false;
			this.btnsubBinary.Click += new System.EventHandler(this.btnsubBinary_Click);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.HotPink;
			this.btnClose.Image = global::Project_CS3.Properties.Resources.door_open__1_;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(754, 722);
			this.btnClose.Name = "btnClose";
			this.btnClose.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnClose.Size = new System.Drawing.Size(167, 60);
			this.btnClose.TabIndex = 21;
			this.btnClose.Text = "Exit";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.HotPink;
			this.btnSave.Image = global::Project_CS3.Properties.Resources.save_to_drive;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(522, 722);
			this.btnSave.Name = "btnSave";
			this.btnSave.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnSave.Size = new System.Drawing.Size(167, 60);
			this.btnSave.TabIndex = 22;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
			// 
			// btnOpen
			// 
			this.btnOpen.BackColor = System.Drawing.Color.HotPink;
			this.btnOpen.Image = global::Project_CS3.Properties.Resources.drag_and_drop;
			this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOpen.Location = new System.Drawing.Point(295, 722);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnOpen.Size = new System.Drawing.Size(167, 60);
			this.btnOpen.TabIndex = 23;
			this.btnOpen.Text = "Open";
			this.btnOpen.UseVisualStyleBackColor = false;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// ContourModule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Yellow;
			this.ClientSize = new System.Drawing.Size(1729, 929);
			this.Controls.Add(this.panelContour);
			this.Controls.Add(this.btnsubBinary);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ContourModule";
			this.Text = "Contour";
			this.Load += new System.EventHandler(this.Contour_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imgOutput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgInput)).EndInit();
			this.panelContour.ResumeLayout(false);
			this.panelContour.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Emgu.CV.UI.ImageBox imgOutput;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private Emgu.CV.UI.ImageBox imgInput;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnsubBinary;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.Panel panelContour;
	}
}