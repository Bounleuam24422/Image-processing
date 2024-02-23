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
using Emgu.CV.CvEnum;
using Emgu.CV.Util;

namespace Project_CS3
{
	public partial class Contour : Form
	{
		public Contour()
		{
			InitializeComponent();
		}
		Image<Bgr, byte> inputImage;
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{

			OpenFileDialog opf = new OpenFileDialog();
			if (opf.ShowDialog() == DialogResult.OK)
			{
				inputImage = new Image<Bgr, byte>(opf.FileName);
				imgInput.Image = inputImage;
			}
		}

		private void simpleThresoldToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Image<Gray, byte> outputImage;
			outputImage = inputImage.Convert<Gray, byte>().ThresholdBinaryInv(new Gray(150), new Gray(255));
			VectorOfVectorOfPoint contour = new VectorOfVectorOfPoint();
			Mat heir = new Mat();

			CvInvoke.FindContours(outputImage, contour, heir, RetrType.External, ChainApproxMethod.ChainApproxSimple);
			Image<Gray, byte> outputImage2 = new Image<Gray, byte>(inputImage.Width, inputImage.Height, new Gray(0));
			CvInvoke.DrawContours(outputImage2, contour, -1, new MCvScalar(255, 0, 255), 2);
			imgOutput.Image = outputImage2;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
