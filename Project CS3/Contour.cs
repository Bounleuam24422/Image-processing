using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing;

namespace Project_CS3
{
	public partial class ContourModule : Form
	{
		public ContourModule()
		{
			InitializeComponent();
			customizeDesing();
		}
		Image<Bgr, byte> inputImage;
		private Form activeForm = null;
		public void openChildForm(Form childForm)
		{
			if (activeForm != null)
				activeForm.Close();
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelContour.Controls.Add(childForm);
			panelContour.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		/* panelSlide*/
		private void customizeDesing()
		{
			panelContour.Visible = false;
		}

		/* hideSubmenu*/
		private void hideSubmenu()
		{
			if (panelContour.Visible == true)
				panelContour.Visible = false;

		}

		/*showSubmenu*/
		private void showSubmenu(Panel submenu)
		{
			if (submenu.Visible == false)
			{
				hideSubmenu();
				submenu.Visible = true;
			}
			else
				submenu.Visible = false;

		}
		private void btnOpen_Click(object sender, EventArgs e)
		{

			OpenFileDialog opf = new OpenFileDialog();
			if (opf.ShowDialog() == DialogResult.OK)
			{
				inputImage = new Image<Bgr, byte>(opf.FileName);
				imgInput.Image = inputImage;
			}
		}

		private void pictureBox15_Click(object sender, EventArgs e)
		{

			if (inputImage == null)
			{
				MessageBox.Show("Input image is empty. Please open an image first.");
				return; // Exit the method if inputImage is empty
			}
			Image<Gray, byte> outputImage;
			outputImage = inputImage.Convert<Gray, byte>().ThresholdBinaryInv(new Gray(150), new Gray(255));
			VectorOfVectorOfPoint contour = new VectorOfVectorOfPoint();
			Mat heir = new Mat();

			CvInvoke.FindContours(outputImage, contour, heir, RetrType.External, ChainApproxMethod.ChainApproxSimple);
			Image<Gray, byte> outputImage2 = new Image<Gray, byte>(inputImage.Width, inputImage.Height, new Gray(0));
			CvInvoke.DrawContours(outputImage2, contour, -1, new MCvScalar(255, 0, 255), 2);
			imgOutput.Image = outputImage2;
		}




		private void Contour_Load(object sender, EventArgs e)
		{

		}

		private void btnSave_Click_1(object sender, EventArgs e)
		{
			if (imgOutput.Image != null)
			{
				SaveFileDialog sfd = new SaveFileDialog();
				sfd.Title = "Save Contour Image";
				sfd.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png";
				if (sfd.ShowDialog() == DialogResult.OK)
				{
					try
					{
						string extension = System.IO.Path.GetExtension(sfd.FileName);
						ImageFormat format = GetImageFormat(extension);
						if (format != null)
						{
							// Convert Emgu.CV.Mat to System.Drawing.Bitmap
							Bitmap bitmap = imgOutput.Image.Bitmap;

							// Save the bitmap
							bitmap.Save(sfd.FileName, format);
							MessageBox.Show("Image saved successfully.");
						}
						else
						{
							MessageBox.Show("Unsupported file format!");
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error saving image: " + ex.Message);
					}
				}
			}
			else
			{
				MessageBox.Show("There is no image to save.");
			}
		}
		private ImageFormat GetImageFormat(string extension)
		{
			switch (extension.ToLower())
			{
				case ".jpg":
					return ImageFormat.Jpeg;
				case ".bmp":
					return ImageFormat.Bmp;
				case ".png":
					return ImageFormat.Png;
				default:
					return null;
			}
		}


		private void btnClose_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnsubBinary_Click(object sender, EventArgs e)
		{
			showSubmenu(panelContour);
		}
	}
}
