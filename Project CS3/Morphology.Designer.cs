namespace Project_CS3
{
	partial class Morphology
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
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.morphologyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dilationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.topHatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.blackHatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.morpholigicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dilationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.erosionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.openingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.closingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.pictureBoxOutput = new System.Windows.Forms.PictureBox();
			this.pictureBoxInput = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).BeginInit();
			this.SuspendLayout();
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// openingToolStripMenuItem
			// 
			this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
			this.openingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.openingToolStripMenuItem.Text = "Opening ";
			this.openingToolStripMenuItem.Click += new System.EventHandler(this.openingToolStripMenuItem_Click);
			// 
			// morphologyToolStripMenuItem
			// 
			this.morphologyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erosionToolStripMenuItem,
            this.dilationToolStripMenuItem,
            this.openingToolStripMenuItem,
            this.closingToolStripMenuItem,
            this.gradientToolStripMenuItem,
            this.topHatToolStripMenuItem,
            this.blackHatToolStripMenuItem,
            this.morpholigicalToolStripMenuItem});
			this.morphologyToolStripMenuItem.Name = "morphologyToolStripMenuItem";
			this.morphologyToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
			this.morphologyToolStripMenuItem.Text = "Morphology";
			// 
			// erosionToolStripMenuItem
			// 
			this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
			this.erosionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.erosionToolStripMenuItem.Text = "Erosion";
			this.erosionToolStripMenuItem.Click += new System.EventHandler(this.erosionToolStripMenuItem_Click);
			// 
			// dilationToolStripMenuItem
			// 
			this.dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
			this.dilationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.dilationToolStripMenuItem.Text = "Dilation";
			this.dilationToolStripMenuItem.Click += new System.EventHandler(this.dilationToolStripMenuItem_Click);
			// 
			// closingToolStripMenuItem
			// 
			this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
			this.closingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.closingToolStripMenuItem.Text = "Closing";
			this.closingToolStripMenuItem.Click += new System.EventHandler(this.closingToolStripMenuItem_Click);
			// 
			// gradientToolStripMenuItem
			// 
			this.gradientToolStripMenuItem.Name = "gradientToolStripMenuItem";
			this.gradientToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.gradientToolStripMenuItem.Text = "Gradient";
			this.gradientToolStripMenuItem.Click += new System.EventHandler(this.gradientToolStripMenuItem_Click);
			// 
			// topHatToolStripMenuItem
			// 
			this.topHatToolStripMenuItem.Name = "topHatToolStripMenuItem";
			this.topHatToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.topHatToolStripMenuItem.Text = "Top Hat";
			this.topHatToolStripMenuItem.Click += new System.EventHandler(this.topHatToolStripMenuItem_Click);
			// 
			// blackHatToolStripMenuItem
			// 
			this.blackHatToolStripMenuItem.Name = "blackHatToolStripMenuItem";
			this.blackHatToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.blackHatToolStripMenuItem.Text = "Black Hat";
			this.blackHatToolStripMenuItem.Click += new System.EventHandler(this.blackHatToolStripMenuItem_Click);
			// 
			// morpholigicalToolStripMenuItem
			// 
			this.morpholigicalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dilationToolStripMenuItem1,
            this.erosionToolStripMenuItem1,
            this.openingToolStripMenuItem1,
            this.closingToolStripMenuItem1});
			this.morpholigicalToolStripMenuItem.Name = "morpholigicalToolStripMenuItem";
			this.morpholigicalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.morpholigicalToolStripMenuItem.Text = "Morpholigical";
			// 
			// dilationToolStripMenuItem1
			// 
			this.dilationToolStripMenuItem1.Name = "dilationToolStripMenuItem1";
			this.dilationToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
			this.dilationToolStripMenuItem1.Text = "Dilation";
			this.dilationToolStripMenuItem1.Click += new System.EventHandler(this.dilationToolStripMenuItem1_Click);
			// 
			// erosionToolStripMenuItem1
			// 
			this.erosionToolStripMenuItem1.Name = "erosionToolStripMenuItem1";
			this.erosionToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
			this.erosionToolStripMenuItem1.Text = "Erosion";
			this.erosionToolStripMenuItem1.Click += new System.EventHandler(this.erosionToolStripMenuItem1_Click);
			// 
			// openingToolStripMenuItem1
			// 
			this.openingToolStripMenuItem1.Name = "openingToolStripMenuItem1";
			this.openingToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
			this.openingToolStripMenuItem1.Text = "Opening";
			this.openingToolStripMenuItem1.Click += new System.EventHandler(this.openingToolStripMenuItem1_Click);
			// 
			// closingToolStripMenuItem1
			// 
			this.closingToolStripMenuItem1.Name = "closingToolStripMenuItem1";
			this.closingToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
			this.closingToolStripMenuItem1.Text = "Closing";
			this.closingToolStripMenuItem1.Click += new System.EventHandler(this.closingToolStripMenuItem1_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.morphologyToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(742, 28);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// pictureBoxOutput
			// 
			this.pictureBoxOutput.Location = new System.Drawing.Point(360, 71);
			this.pictureBoxOutput.Name = "pictureBoxOutput";
			this.pictureBoxOutput.Size = new System.Drawing.Size(352, 334);
			this.pictureBoxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxOutput.TabIndex = 8;
			this.pictureBoxOutput.TabStop = false;
			// 
			// pictureBoxInput
			// 
			this.pictureBoxInput.Location = new System.Drawing.Point(12, 71);
			this.pictureBoxInput.Name = "pictureBoxInput";
			this.pictureBoxInput.Size = new System.Drawing.Size(342, 334);
			this.pictureBoxInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxInput.TabIndex = 7;
			this.pictureBoxInput.TabStop = false;
			// 
			// Morphology
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(742, 438);
			this.Controls.Add(this.pictureBoxOutput);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.pictureBoxInput);
			this.Name = "Morphology";
			this.Text = "Morphology";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxOutput;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem morphologyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gradientToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem topHatToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem blackHatToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem morpholigicalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.PictureBox pictureBoxInput;
	}
}