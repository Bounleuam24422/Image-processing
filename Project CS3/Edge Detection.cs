using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CS3
{
	public partial class Edge_Detection : Form
	{
		public Edge_Detection()
		{
			InitializeComponent();
		}
		Image<Bgr, byte> inputImage;
		Image<Gray, byte> outputImage;
		Image<Gray, float> sobelImage, laplacianImage;

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog savef = new SaveFileDialog();
			savef.Title = "Image Equalization and Filtering";
			string imageName = "My image";
			savef.FileName = imageName;
			savef.Filter = "Jpeg Files(*.jpg)|*.jpg|Bitmap Files(*.bmp)|*.bmp";
			if (savef.ShowDialog() == DialogResult.OK)
			{
				imgOutput.Image.Save(savef.FileName);
				MessageBox.Show("Saving Complete");
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void candyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (inputImage != null)
			{
				outputImage = inputImage.Convert<Gray, byte>().Canny(150, 10);
				imgOutput.Image = outputImage;
			}
		}

		private void sobleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (inputImage != null)
			{
				sobelImage = inputImage.Convert<Gray, float>().Sobel(1, 1, 5);
				imgOutput.Image = sobelImage;
			}
		}

		private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (inputImage != null)
			{
				laplacianImage = inputImage.Convert<Gray, float>().Laplace(5);
				imgOutput.Image = laplacianImage;
			}
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog opf = new OpenFileDialog();
			opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tiff";
			if (opf.ShowDialog() == DialogResult.OK)
			{
				inputImage = new Image<Bgr, byte>(opf.FileName);
				imgInput.Image = inputImage;
			}
		}
	}
}
