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
			this.radioBgr = new System.Windows.Forms.RadioButton();
			this.radioGray = new System.Windows.Forms.RadioButton();
			this.htgAfterE = new Emgu.CV.UI.HistogramBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnSaveImage = new System.Windows.Forms.Button();
			this.btnMedian = new System.Windows.Forms.Button();
			this.btnGuassian = new System.Windows.Forms.Button();
			this.btnEqualization = new System.Windows.Forms.Button();
			this.txtksize = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnLoadImage = new System.Windows.Forms.Button();
			this.htgGray = new Emgu.CV.UI.HistogramBox();
			this.htgBeforeE = new Emgu.CV.UI.HistogramBox();
			this.imgBoxGray = new Emgu.CV.UI.ImageBox();
			this.ImgBoxOutput = new Emgu.CV.UI.ImageBox();
			this.imgBoxInput = new Emgu.CV.UI.ImageBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgBoxGray)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBoxOutput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgBoxInput)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioBgr);
			this.groupBox1.Controls.Add(this.radioGray);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(742, 151);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(127, 94);
			this.groupBox1.TabIndex = 61;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ເລືອກ Noise";
			// 
			// radioBgr
			// 
			this.radioBgr.AutoSize = true;
			this.radioBgr.Location = new System.Drawing.Point(25, 31);
			this.radioBgr.Name = "radioBgr";
			this.radioBgr.Size = new System.Drawing.Size(52, 22);
			this.radioBgr.TabIndex = 29;
			this.radioBgr.TabStop = true;
			this.radioBgr.Text = "Bgr";
			this.radioBgr.UseVisualStyleBackColor = true;
			// 
			// radioGray
			// 
			this.radioGray.AutoSize = true;
			this.radioGray.Location = new System.Drawing.Point(25, 59);
			this.radioGray.Name = "radioGray";
			this.radioGray.Size = new System.Drawing.Size(61, 22);
			this.radioGray.TabIndex = 30;
			this.radioGray.TabStop = true;
			this.radioGray.Text = "Gray";
			this.radioGray.UseVisualStyleBackColor = true;
			// 
			// htgAfterE
			// 
			this.htgAfterE.Location = new System.Drawing.Point(354, 498);
			this.htgAfterE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.htgAfterE.Name = "htgAfterE";
			this.htgAfterE.Size = new System.Drawing.Size(313, 251);
			this.htgAfterE.TabIndex = 58;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(742, 425);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(127, 35);
			this.btnExit.TabIndex = 56;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnSaveImage
			// 
			this.btnSaveImage.Location = new System.Drawing.Point(742, 373);
			this.btnSaveImage.Name = "btnSaveImage";
			this.btnSaveImage.Size = new System.Drawing.Size(127, 35);
			this.btnSaveImage.TabIndex = 55;
			this.btnSaveImage.Text = "Save Image";
			this.btnSaveImage.UseVisualStyleBackColor = true;
			this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
			// 
			// btnMedian
			// 
			this.btnMedian.Location = new System.Drawing.Point(742, 319);
			this.btnMedian.Name = "btnMedian";
			this.btnMedian.Size = new System.Drawing.Size(127, 35);
			this.btnMedian.TabIndex = 54;
			this.btnMedian.Text = "Median Filter";
			this.btnMedian.UseVisualStyleBackColor = true;
			this.btnMedian.Click += new System.EventHandler(this.btnMedian_Click);
			// 
			// btnGuassian
			// 
			this.btnGuassian.Location = new System.Drawing.Point(742, 265);
			this.btnGuassian.Name = "btnGuassian";
			this.btnGuassian.Size = new System.Drawing.Size(127, 35);
			this.btnGuassian.TabIndex = 53;
			this.btnGuassian.Text = "Guassian Filter";
			this.btnGuassian.UseVisualStyleBackColor = true;
			this.btnGuassian.Click += new System.EventHandler(this.btnGuassian_Click);
			// 
			// btnEqualization
			// 
			this.btnEqualization.Location = new System.Drawing.Point(742, 77);
			this.btnEqualization.Name = "btnEqualization";
			this.btnEqualization.Size = new System.Drawing.Size(127, 58);
			this.btnEqualization.TabIndex = 52;
			this.btnEqualization.Text = "Histogram Equalization";
			this.btnEqualization.UseVisualStyleBackColor = true;
			this.btnEqualization.Click += new System.EventHandler(this.btnEqualization_Click);
			// 
			// txtksize
			// 
			this.txtksize.Location = new System.Drawing.Point(769, 498);
			this.txtksize.Name = "txtksize";
			this.txtksize.Size = new System.Drawing.Size(92, 22);
			this.txtksize.TabIndex = 60;
			this.txtksize.Text = "7";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(721, 504);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 16);
			this.label1.TabIndex = 59;
			this.label1.Text = "Ksize:";
			// 
			// btnLoadImage
			// 
			this.btnLoadImage.Location = new System.Drawing.Point(742, 24);
			this.btnLoadImage.Name = "btnLoadImage";
			this.btnLoadImage.Size = new System.Drawing.Size(127, 35);
			this.btnLoadImage.TabIndex = 51;
			this.btnLoadImage.Text = "Load Image";
			this.btnLoadImage.UseVisualStyleBackColor = true;
			this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
			// 
			// htgGray
			// 
			this.htgGray.Location = new System.Drawing.Point(354, 243);
			this.htgGray.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.htgGray.Name = "htgGray";
			this.htgGray.Size = new System.Drawing.Size(313, 251);
			this.htgGray.TabIndex = 49;
			// 
			// htgBeforeE
			// 
			this.htgBeforeE.Location = new System.Drawing.Point(354, 24);
			this.htgBeforeE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.htgBeforeE.Name = "htgBeforeE";
			this.htgBeforeE.Size = new System.Drawing.Size(313, 211);
			this.htgBeforeE.TabIndex = 48;
			// 
			// imgBoxGray
			// 
			this.imgBoxGray.Location = new System.Drawing.Point(37, 241);
			this.imgBoxGray.Name = "imgBoxGray";
			this.imgBoxGray.Size = new System.Drawing.Size(268, 251);
			this.imgBoxGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgBoxGray.TabIndex = 57;
			this.imgBoxGray.TabStop = false;
			// 
			// ImgBoxOutput
			// 
			this.ImgBoxOutput.Location = new System.Drawing.Point(37, 498);
			this.ImgBoxOutput.Name = "ImgBoxOutput";
			this.ImgBoxOutput.Size = new System.Drawing.Size(268, 251);
			this.ImgBoxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImgBoxOutput.TabIndex = 50;
			this.ImgBoxOutput.TabStop = false;
			// 
			// imgBoxInput
			// 
			this.imgBoxInput.Location = new System.Drawing.Point(37, 24);
			this.imgBoxInput.Name = "imgBoxInput";
			this.imgBoxInput.Size = new System.Drawing.Size(268, 211);
			this.imgBoxInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgBoxInput.TabIndex = 47;
			this.imgBoxInput.TabStop = false;
			// 
			// Histogram_Equalization
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(936, 770);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.htgAfterE);
			this.Controls.Add(this.imgBoxGray);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSaveImage);
			this.Controls.Add(this.btnMedian);
			this.Controls.Add(this.btnGuassian);
			this.Controls.Add(this.btnEqualization);
			this.Controls.Add(this.txtksize);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnLoadImage);
			this.Controls.Add(this.ImgBoxOutput);
			this.Controls.Add(this.htgGray);
			this.Controls.Add(this.htgBeforeE);
			this.Controls.Add(this.imgBoxInput);
			this.Name = "Histogram_Equalization";
			this.Text = "Histogram_Equalization";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgBoxGray)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBoxOutput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgBoxInput)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioBgr;
		private System.Windows.Forms.RadioButton radioGray;
		private Emgu.CV.UI.HistogramBox htgAfterE;
		private Emgu.CV.UI.ImageBox imgBoxGray;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnSaveImage;
		private System.Windows.Forms.Button btnMedian;
		private System.Windows.Forms.Button btnGuassian;
		private System.Windows.Forms.Button btnEqualization;
		private System.Windows.Forms.TextBox txtksize;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnLoadImage;
		private Emgu.CV.UI.ImageBox ImgBoxOutput;
		private Emgu.CV.UI.HistogramBox htgGray;
		private Emgu.CV.UI.HistogramBox htgBeforeE;
		private Emgu.CV.UI.ImageBox imgBoxInput;
	}
}