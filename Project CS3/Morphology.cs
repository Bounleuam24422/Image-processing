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

namespace Project_CS3
{
	public partial class Morphology : Form
	{
		Image<Bgr, byte> inputImage;
		Image<Bgr, byte> colorImage;
		Image<Gray, byte> binaryImage, morphoImage;
		public Morphology()
		{
			InitializeComponent();
			customizeDesing();
		}
		private Form activeForm = null;
		public void openChildForm(Form childForm)
		{
			if (activeForm != null)
				activeForm.Close();
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelSubMorGy.Controls.Add(childForm);
			panelSubMorGy.Tag = childForm;
			panelSubMorCal.Controls.Add(childForm);
			panelSubMorCal.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();

		}

		/* panelSlide*/
		private void customizeDesing()
		{
			panelSubMorGy.Visible = false;
			panelSubMorCal.Visible = false;
		}

		/* hideSubmenu*/
		private void hideSubmenu()
		{
			if (panelSubMorGy.Visible == true)
				panelSubMorCal.Visible = true;

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

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog savef = new SaveFileDialog();
			savef.Title = "Image Equalization and Filtering";
			string imageName = "My image";
			savef.FileName = imageName;
			savef.Filter = "Jpeg Files(*.jpg)|*.jpg|Bitmap Files(*.bmp)|*.bmp";
			if (savef.ShowDialog() == DialogResult.OK)
			{
				pictureBoxOutput.Image.Save(savef.FileName);
				MessageBox.Show("Saving Complete");
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (inputImage == null)
			{
				return;
			}
			pictureBoxOutput.Image = inputImage.Erode(1).Bitmap;
		}

		private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(inputImage == null)
			{
				return;
			}
			pictureBoxOutput.Image = inputImage.Dilate(1).Bitmap;
		}

		private void openingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (inputImage != null)
			{
				colorImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
				Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
				colorImage = inputImage.MorphologyEx(MorphOp.Open, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(1.0));
				pictureBoxOutput.Image = colorImage.ToBitmap();
			}
		}

		private void closingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (inputImage != null)
			{
				colorImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
				Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new
			   Point(-1, -1));
				colorImage = inputImage.MorphologyEx(MorphOp.Close, kernel, new Point(-1, -1),
				1, BorderType.Default, new MCvScalar(1.0));
				pictureBoxOutput.Image = colorImage.ToBitmap();
			}
		}

		private void gradientToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (inputImage != null)
			{
				colorImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
				Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new
			   Point(-1, -1));
				colorImage = inputImage.MorphologyEx(MorphOp.Gradient, kernel, new Point(-1, -1),
				1, BorderType.Default, new MCvScalar(1.0));
				pictureBoxOutput.Image = colorImage.ToBitmap();
			}
		}

		private void topHatToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (inputImage != null)
			{
				colorImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
				Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new
			   Point(-1, -1));
				colorImage = inputImage.MorphologyEx(MorphOp.Tophat, kernel, new Point(-1, -1),
				1, BorderType.Default, new MCvScalar(1.0));
				pictureBoxOutput.Image = colorImage.ToBitmap();
			}
		}

		private void blackHatToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (inputImage != null)
			{
				colorImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
				Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new
			   Point(-1, -1));
				colorImage = inputImage.MorphologyEx(MorphOp.Blackhat, kernel, new Point(-1, -1),
				1, BorderType.Default, new MCvScalar(1.0));
				pictureBoxOutput.Image = colorImage.ToBitmap();
			}
		}

		private void dilationToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (inputImage == null)
			{
				return;
			}
			pictureBoxOutput.Image = inputImage.Convert<Gray,
			byte>().ThresholdBinary(new Gray(150),
			new Gray(255)).Dilate(1).Bitmap;
		}

		private void erosionToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (inputImage == null)
			{
				return;
			}
			pictureBoxOutput.Image = inputImage.Convert<Gray,
			byte>().ThresholdBinary(new Gray(150),
			new Gray(255)).Erode(1).Bitmap;
		}

		private void openingToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (inputImage != null)
			{
				//binaryImage = inputImage.Convert<Gray, byte>().ThresholdBinary(new Gray(150), new Gray(255));
				binaryImage = inputImage.Convert<Gray, byte>().ThresholdBinaryInv(new Gray(150), new Gray(255));
				Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new
			   Point(-1, -1));
				morphoImage = binaryImage.MorphologyEx(MorphOp.Open, kernel, new Point(-1, -1),
				1, BorderType.Default, new MCvScalar(1.0));

				pictureBoxOutput.Image = morphoImage.ToBitmap();
			}
		}

		private void closingToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (inputImage != null)
			{
				binaryImage = inputImage.Convert<Gray, byte>().ThresholdBinaryInv(new Gray(150), new Gray(255));
				Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
				morphoImage = binaryImage.MorphologyEx(MorphOp.Close, kernel, new Point(-1, -1),
				1, BorderType.Default, new MCvScalar(1.0));
				pictureBoxOutput.Image = morphoImage.ToBitmap();
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			SaveFileDialog savef = new SaveFileDialog();
			savef.Title = "Image Equalization and Filtering";
			string imageName = "My image";
			savef.FileName = imageName;
			savef.Filter = "Jpeg Files(*.jpg)|*.jpg|Bitmap Files(*.bmp)|*.bmp";
			if (savef.ShowDialog() == DialogResult.OK)
			{
				pictureBoxOutput.Image.Save(savef.FileName);
				MessageBox.Show("Saving Complete");
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnmgyErosion_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			if (inputImage == null)
			{
				MessageBox.Show("Please input an image first.");
				return; // Exit the method if inputImage is null
			}

			pictureBoxOutput.Image = inputImage.Erode(1).Bitmap;
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			if(inputImage == null)
			{
				MessageBox.Show("Please input an image first.");
				return; // Exit the method if inputImage is null
			}
			pictureBoxOutput.Image = inputImage.Dilate(1).Bitmap;
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			if (inputImage == null)
			{
				MessageBox.Show("Please input an image first.");
				return; // Exit the method if inputImage is null
			}
			colorImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
				Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
				colorImage = inputImage.MorphologyEx(MorphOp.Open, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(1.0));
				pictureBoxOutput.Image = colorImage.ToBitmap();
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			if(inputImage == null)
			{
				MessageBox.Show("Please input an image first.");
				return; // Exit the method if inputImage is null
			}
			colorImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
				Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new
			   Point(-1, -1));
				colorImage = inputImage.MorphologyEx(MorphOp.Close, kernel, new Point(-1, -1),
				1, BorderType.Default, new MCvScalar(1.0));
				pictureBoxOutput.Image = colorImage.ToBitmap();
			
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			if (inputImage == null)
			{
				MessageBox.Show("Please input an image first.");
				return; // Exit the method if inputImage is null
			}
			colorImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
				Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new
			   Point(-1, -1));
				colorImage = inputImage.MorphologyEx(MorphOp.Gradient, kernel, new Point(-1, -1),
				1, BorderType.Default, new MCvScalar(1.0));
				pictureBoxOutput.Image = colorImage.ToBitmap();
			
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			if(inputImage == null)
			{
				MessageBox.Show("Please input an image first.");
				return; // Exit the method if inputImage is null
			}
			colorImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
				Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new
			   Point(-1, -1));
				colorImage = inputImage.MorphologyEx(MorphOp.Tophat, kernel, new Point(-1, -1),
				1, BorderType.Default, new MCvScalar(1.0));
				pictureBoxOutput.Image = colorImage.ToBitmap();
			
		}

		private void btnmgyTop_Hat_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox8_Click(object sender, EventArgs e)
		{
			if (inputImage == null)
			{
				MessageBox.Show("Please input an image first.");
				return; // Exit the method if inputImage is null
			}
			colorImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
				Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new
			   Point(-1, -1));
				colorImage = inputImage.MorphologyEx(MorphOp.Blackhat, kernel, new Point(-1, -1),
				1, BorderType.Default, new MCvScalar(1.0));
				pictureBoxOutput.Image = colorImage.ToBitmap();
			
		}

		private void pictureBox10_Click(object sender, EventArgs e)
		{
			if (inputImage == null)
			{
				MessageBox.Show("Please input an image first.");
				return; // Exit the method if inputImage is null
			}
			pictureBoxOutput.Image = inputImage.Convert<Gray,
			byte>().ThresholdBinary(new Gray(150),
			new Gray(255)).Dilate(1).Bitmap;
		}

		private void pictureBox11_Click(object sender, EventArgs e)
		{
			if (inputImage == null)
			{
				MessageBox.Show("Please input an image first.");
				return; // Exit the method if inputImage is null
			}
			pictureBoxOutput.Image = inputImage.Convert<Gray,
			byte>().ThresholdBinary(new Gray(150),
			new Gray(255)).Erode(1).Bitmap;
		}

		private void pictureBox12_Click(object sender, EventArgs e)
		{
			if (inputImage == null)
			{
				MessageBox.Show("Please input an image first.");
				return; // Exit the method if inputImage is null
			}
			//binaryImage = inputImage.Convert<Gray, byte>().ThresholdBinary(new Gray(150), new Gray(255));
			binaryImage = inputImage.Convert<Gray, byte>().ThresholdBinaryInv(new Gray(150), new Gray(255));
				Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new
			   Point(-1, -1));
				morphoImage = binaryImage.MorphologyEx(MorphOp.Open, kernel, new Point(-1, -1),
				1, BorderType.Default, new MCvScalar(1.0));

				pictureBoxOutput.Image = morphoImage.ToBitmap();
			
		}

		private void pictureBox13_Click(object sender, EventArgs e)
		{
			if (inputImage == null)
			{
				MessageBox.Show("Please input an image first.");
				return; // Exit the method if inputImage is null
			}
			binaryImage = inputImage.Convert<Gray, byte>().ThresholdBinaryInv(new Gray(150), new Gray(255));
				Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
				morphoImage = binaryImage.MorphologyEx(MorphOp.Close, kernel, new Point(-1, -1),
				1, BorderType.Default, new MCvScalar(1.0));
				pictureBoxOutput.Image = morphoImage.ToBitmap();
			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			showSubmenu(panelSubMorGy);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			showSubmenu(panelSubMorCal);
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFile = new OpenFileDialog();
			openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tiff";
			if (openFile.ShowDialog() == DialogResult.OK)
			{
				inputImage = new Image<Bgr, byte>(openFile.FileName);
				pictureBoxInput.Image = inputImage.ToBitmap();

			}
		}		
	}
}
