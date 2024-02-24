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
			customizeDesing();
		}
		Image<Bgr, byte> inputImage;
		Image<Gray, byte> outputImage;
		Image<Gray, float> sobelImage, laplacianImage;

		private Form activeForm = null;
		public void openChildForm(Form childForm)
		{
			if (activeForm != null)
				activeForm.Close();
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelSubEdDtion.Controls.Add(childForm);
			panelSubEdDtion.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		/* panelSlide*/
		private void customizeDesing()
		{
			panelSubEdDtion.Visible = false;
		}

		/* hideSubmenu*/
		private void hideSubmenu()
		{
			if (panelSubEdDtion.Visible == true)
				panelSubEdDtion.Visible = false;

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

		private void pictureBox15_Click(object sender, EventArgs e)
		{
			if (inputImage == null)
			{
				MessageBox.Show("Please load an image first.");
				return; // Exit the method if oriImage is null
			}
		
				outputImage = inputImage.Convert<Gray, byte>().Canny(150, 10);
				imgOutput.Image = outputImage;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if (inputImage == null)
			{
				MessageBox.Show("Please load an image first.");
				return; // Exit the method if oriImage is null
			}
			sobelImage = inputImage.Convert<Gray, float>().Sobel(1, 1, 5);
				imgOutput.Image = sobelImage;
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			if (inputImage == null)
			{
				MessageBox.Show("Please load an image first.");
				return; // Exit the method if oriImage is null
			}
			laplacianImage = inputImage.Convert<Gray, float>().Laplace(5);
				imgOutput.Image = laplacianImage;
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			OpenFileDialog opf = new OpenFileDialog();
			opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tiff";
			if (opf.ShowDialog() == DialogResult.OK)
			{
				inputImage = new Image<Bgr, byte>(opf.FileName);
				imgInput.Image = inputImage;
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
				imgOutput.Image.Save(savef.FileName);
				MessageBox.Show("Saving Complete");
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnsubBinary_Click(object sender, EventArgs e)
		{
			showSubmenu(panelSubEdDtion);
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
