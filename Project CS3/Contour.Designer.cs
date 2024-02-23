namespace Project_CS3
{
	partial class Contour
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.simpleThresoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.imgOutput = new Emgu.CV.UI.ImageBox();
			this.imgInput = new Emgu.CV.UI.ImageBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgOutput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgInput)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(733, 28);
			this.menuStrip1.TabIndex = 10;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.simpleThresoldToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.openToolStripMenuItem.Text = "Open ";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// simpleThresoldToolStripMenuItem
			// 
			this.simpleThresoldToolStripMenuItem.Name = "simpleThresoldToolStripMenuItem";
			this.simpleThresoldToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.simpleThresoldToolStripMenuItem.Text = "Find Contour";
			this.simpleThresoldToolStripMenuItem.Click += new System.EventHandler(this.simpleThresoldToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// imgOutput
			// 
			this.imgOutput.Location = new System.Drawing.Point(349, 73);
			this.imgOutput.Name = "imgOutput";
			this.imgOutput.Size = new System.Drawing.Size(335, 370);
			this.imgOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgOutput.TabIndex = 8;
			this.imgOutput.TabStop = false;
			// 
			// imgInput
			// 
			this.imgInput.Location = new System.Drawing.Point(15, 73);
			this.imgInput.Name = "imgInput";
			this.imgInput.Size = new System.Drawing.Size(307, 370);
			this.imgInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgInput.TabIndex = 9;
			this.imgInput.TabStop = false;
			// 
			// Contour
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(733, 475);
			this.Controls.Add(this.imgOutput);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.imgInput);
			this.Name = "Contour";
			this.Text = "Contour";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgOutput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgInput)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Emgu.CV.UI.ImageBox imgOutput;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem simpleThresoldToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private Emgu.CV.UI.ImageBox imgInput;
	}
}