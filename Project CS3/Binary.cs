using Emgu.CV.CvEnum;
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
	public partial class BinaryModule : Form
	{
		public BinaryModule()
		{
			InitializeComponent();
		}
		Image<Bgr, byte> oriImage;
		Image<Gray, byte> grayImage, binaryImage;



		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			OpenFileDialog opf = new OpenFileDialog();
			opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tiff";
			if (opf.ShowDialog() == DialogResult.OK)
			{
				oriImage = new Image<Bgr, byte>(opf.FileName);
				imgInput.Image = oriImage;
				grayImage = oriImage.Convert<Gray, byte>();
				imgGray.Image = grayImage;
				imgBinary.Image = null;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (imgInput.Image == null)
			{
				MessageBox.Show("Please load an image first.");
			}
			else if (imgBinary.Image == null)
			{
				MessageBox.Show("Please convert the image to grayscale first.");
			}
			else
			{
				using (SaveFileDialog saveImage = new SaveFileDialog())
				{
					saveImage.Title = "Save Gray Image";
					string imageName = "My image";

					// Set the file name
					saveImage.FileName = imageName;
					saveImage.DefaultExt = "*.jpg";
					saveImage.Filter = "JPEG Files (*.jpg)|*.jpg|PNG files(*.png)|*.png|BMP files(*.bmp)|*.bmp";

					if (saveImage.ShowDialog() == DialogResult.OK)
					{
						// ตรวจสอบจำนวน channels ของภาพ
						if (imgBinary.Image is Image<Gray, byte> grayImage)
						{
							// บันทึกภาพเป็นไฟล์
							grayImage.Save(saveImage.FileName);
							MessageBox.Show("Saving Complete");
						}
						else
						{
							MessageBox.Show("Invalid image format. Please convert the image to grayscale first.");
						}
					}
				}
			}
		}

		private void btnBinary_Click(object sender, EventArgs e)
		{
			if (oriImage == null)
			{
				MessageBox.Show("Please load an image first.");
				return; // Exit the method if oriImage is null
			}
			binaryImage = grayImage.ThresholdBinary(new Gray(100), new Gray(255));
			imgBinary.Image = binaryImage;
		}

		private void btnBiny_Inver_Click(object sender, EventArgs e)
		{
			if (oriImage == null)
			{
				MessageBox.Show("Please load an image first.");
				return; // Exit the method if oriImage is null
			}
			binaryImage = grayImage.ThresholdBinaryInv(new Gray(100), new Gray(255));
			imgBinary.Image = binaryImage;
		}

		private void btnOT_Su_Click(object sender, EventArgs e)
		{
			if (oriImage == null)
			{
				MessageBox.Show("Please load an image first.");
				return; // Exit the method if oriImage is null
			}
			binaryImage = grayImage.ThresholdToZero(new Gray(100));
			imgBinary.Image = binaryImage;
		}

		private void btnGuasian_Click(object sender, EventArgs e)
		{
			if (oriImage == null)
			{
				MessageBox.Show("Please load an image first.");
				return; // Exit the method if oriImage is null
			}
			binaryImage = grayImage.ThresholdAdaptive(new Gray(256),
			AdaptiveThresholdType.GaussianC, ThresholdType.Binary, 9, new Gray(0));
			imgBinary.Image = binaryImage;
		}

		private void btnMean_Click(object sender, EventArgs e)
		{
			if (oriImage == null)
			{
				MessageBox.Show("Please load an image first.");
				return; // Exit the method if oriImage is null
			}
			binaryImage = grayImage.ThresholdAdaptive(new Gray(256),
			AdaptiveThresholdType.MeanC, ThresholdType.Binary, 9, new Gray(0));
			imgBinary.Image = binaryImage;
		}

	}
}
