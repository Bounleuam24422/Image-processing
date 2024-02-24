using Emgu.CV.Structure;
using Emgu.CV;
using Emgu.CV.CvEnum;
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
	public partial class Histogram_Equalization : Form
	{
		Image<Bgr, byte> imgBeforeE, imgFilterC;
		Image<Gray, byte> imgFilter, imgAfterE, imgGray;
		public Histogram_Equalization()
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
			panelSubHisgram.Controls.Add(childForm);
			panelSubHisgram.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		/* panelSlide*/
		private void customizeDesing()
		{
			panelSubHisgram.Visible = false;
		}

		/* hideSubmenu*/
		private void hideSubmenu()
		{
			if (panelSubHisgram.Visible == true)
				panelSubHisgram.Visible = false;

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




		private void btnSaveImage_Click(object sender, EventArgs e)
		{

			SaveFileDialog savef = new SaveFileDialog();
			savef.Title = "Image Equalization and Filtering";
			string imageName = "My image";
			savef.FileName = imageName;
			savef.Filter = "Jpeg Files(*.jpg)|*.jpg|Bitmap Files(*.bmp)|*.bmp";
			if (savef.ShowDialog() == DialogResult.OK)
			{
				ImgBoxOutput.Image.Save(savef.FileName);
				MessageBox.Show("Saving Complete");
			}
		}

		private void pictureBox15_Click(object sender, EventArgs e)
		{
			if (imgBoxInput.Image == null)
			{
				MessageBox.Show("Please input an image first.");
				return; // Exit the method if imgBoxInput is empty
			}

			imgAfterE = new Image<Gray, byte>(imgBeforeE.Width, imgBeforeE.Height);
			CvInvoke.EqualizeHist(imgGray, imgAfterE);
			ImgBoxOutput.Image = imgAfterE;
			htgAfterE.ClearHistogram();
			htgAfterE.GenerateHistograms(imgAfterE, 255);
			htgAfterE.Refresh();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			if (imgBoxInput.Image == null)
			{
				MessageBox.Show("Please input an image first.");
				return; // Exit the method if imgBoxInput is empty
			}

			if (radioBgr.Checked)
			{
				if (int.TryParse(txtksize.Text, out int ksize) && ksize > 0 && ksize % 2 == 1)
				{
					imgFilterC = new Image<Bgr, byte>(imgBeforeE.Width, imgBeforeE.Height);
					CvInvoke.GaussianBlur(imgBeforeE, imgFilterC, new Size(3, 3), 0, 0, BorderType.Default);
					ImgBoxOutput.Image = imgFilterC;
					ImgBoxOutput.Refresh();
					htgAfterE.ClearHistogram();
					htgAfterE.GenerateHistograms(imgFilterC, 255);
					htgAfterE.Refresh();
				}
				else
				{
					MessageBox.Show("Please enter a valid odd integer for ksize greater than 1.");
				}
			}

			else if (radioGray.Checked)
			{
				if (int.TryParse(txtksize.Text, out int ksize) && ksize > 0 && ksize % 2 == 1)
				{
					imgFilter = new Image<Gray, byte>(imgGray.Width, imgGray.Height);
					CvInvoke.GaussianBlur(imgGray, imgFilter, new Size(ksize, ksize), 0, 0, BorderType.Default);

					ImgBoxOutput.Image = imgFilter;
					ImgBoxOutput.Refresh();
					htgAfterE.ClearHistogram();
					htgAfterE.GenerateHistograms(imgFilter, 255);
					htgAfterE.Refresh();
				}
				else
				{
					//   MessageBox.Show("Please enter a valid odd integer for ksize greater than 1.");
				}
		}
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			if (imgBoxInput.Image == null)
			{
				MessageBox.Show("Please input an image first.");
				return; // Exit the method if imgBoxInput is empty
			}

			if (radioBgr.Checked)
			{
				if (int.TryParse(txtksize.Text, out int ksize) && ksize > 0 && ksize % 2 == 1)
				{
					imgFilterC = new Image<Bgr, byte>(imgBeforeE.Width, imgBeforeE.Height);
					CvInvoke.MedianBlur(imgBeforeE, imgFilterC, ksize);
					ImgBoxOutput.Image = imgFilterC;
					ImgBoxOutput.Refresh();
					htgAfterE.ClearHistogram();
					htgAfterE.GenerateHistograms(imgFilterC, 255);
					htgAfterE.Refresh();
				}
				else
				{
					MessageBox.Show("Please enter a valid odd integer for ksize greater than 1.");
				}
			}

			else if (radioGray.Checked)
			{
				if (int.TryParse(txtksize.Text, out int ksize) && ksize > 0 && ksize % 2 == 1)
				{
					imgFilter = new Image<Gray, byte>(imgGray.Width, imgGray.Height);
					CvInvoke.MedianBlur(imgGray, imgFilter, ksize);

					ImgBoxOutput.Image = imgFilter;
					ImgBoxOutput.Refresh();
					htgAfterE.ClearHistogram();
					htgAfterE.GenerateHistograms(imgFilter, 255);
					htgAfterE.Refresh();
				}
				else
				{
					MessageBox.Show("Please enter a valid odd integer for ksize greater than 1.");
				}
			}
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			OpenFileDialog opf = new OpenFileDialog();
			opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tiff";
			if (opf.ShowDialog() == DialogResult.OK)
			{
				imgBeforeE = new Image<Bgr, byte>(opf.FileName);
				imgBoxInput.Image = imgBeforeE;
				htgBeforeE.GenerateHistograms(imgBeforeE, 255);
				htgBeforeE.Refresh();

				imgGray = new Image<Gray, byte>(opf.FileName);
				imgBoxGray.Image = imgGray;
				htgGray.GenerateHistograms(imgGray, 255);
				htgGray.Refresh();
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
				ImgBoxOutput.Image.Save(savef.FileName);
				MessageBox.Show("Saving Complete");
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void radioBgr_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void btnsubBinary_Click(object sender, EventArgs e)
		{
			showSubmenu(panelSubHisgram);
		}

		private void radioGray_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		

		private void btnLoadImage_Click(object sender, EventArgs e)
		{
			OpenFileDialog opf = new OpenFileDialog();
			opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tiff";
			if (opf.ShowDialog() == DialogResult.OK)
			{
				imgBeforeE = new Image<Bgr, byte>(opf.FileName);
				imgBoxInput.Image = imgBeforeE;
				htgBeforeE.GenerateHistograms(imgBeforeE, 255);
				htgBeforeE.Refresh();

				imgGray = new Image<Gray, byte>(opf.FileName);
				imgBoxGray.Image = imgGray;
				htgGray.GenerateHistograms(imgGray, 255);
				htgGray.Refresh();
			}
		}
	}
}
