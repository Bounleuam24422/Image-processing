using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CS3
{
	public partial class panelWeb_camModule : Form
	{
		public panelWeb_camModule()
		{
			InitializeComponent();
			customizeDesing();
		}
		Image<Gray, byte> grayVDO, binaryVDO;
		VideoCapture capture;
		Mat frame;
		bool turn_on;

		private Form activeForm = null;
		public void openChildForm(Form childForm)
		{
			if (activeForm != null)
				activeForm.Close();
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelWebcam.Controls.Add(childForm);
			panelWebcam.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		/* panelSlide*/
		private void customizeDesing()
		{
			panelWebcam.Visible = false;
		}

		/* hideSubmenu*/
		private void hideSubmenu()
		{
			if (panelWebcam.Visible == true)
				panelWebcam.Visible = false;

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
		private void btnStart_Click(object sender, EventArgs e)
		{
			turn_on = true;
			imgCapture.Image = null;
			Application.Idle += Application_Idle;
		}
		private void Application_Idle(object sender, EventArgs e)
		{
			if (capture != null)
			{
				capture.Retrieve(frame);
				imgBoxVDO.Image = frame.ToImage<Bgr, byte>().ToBitmap();
			}
		}
		private void btnStop_Click(object sender, EventArgs e)
		{
			turn_on = false;
			Application.Idle -= Application_Idle;
		}
		private void Application_Idle1(object sender, EventArgs e)
		{
			grayVDO = frame.ToImage<Gray, byte>();
			imgBoxVDO.Image = grayVDO.ToBitmap();
		}
		private void btnGray_Click(object sender, EventArgs e)
		{
			if (turn_on == true)
				Application.Idle += Application_Idle1;
			else
				MessageBox.Show("Please Start the WebCam");
		}
		private void Application_Idle2(object sender, EventArgs e)
		{
			grayVDO = frame.ToImage<Gray, byte>();
			binaryVDO = grayVDO.ThresholdBinary(new Gray(150), new Gray(255));
			imgBoxVDO.Image = binaryVDO.ToBitmap();
		}
		private void btnBinary_Click(object sender, EventArgs e)
		{
			if (turn_on == true)
				Application.Idle += Application_Idle2;
			else
				MessageBox.Show("Please Start the WebCam");
		}

		private void btnCapture_Click(object sender, EventArgs e)
		{
			imgCapture.Image = imgBoxVDO.Image;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			SaveFileDialog svf = new SaveFileDialog();
			svf.Title = "Save Capture Image";
			svf.DefaultExt = "*.Jpg";
			svf.Filter = "Jpeg Files (*.jpg)|*.jpg";
			if (svf.ShowDialog() == DialogResult.OK)
			{
				imgCapture.Image.Save(svf.FileName);
			}
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			if (turn_on == true)
				Application.Idle += Application_Idle1;
			else
				MessageBox.Show("Please Start the WebCam");
		}

		private void pictureBox15_Click(object sender, EventArgs e)
		{
			if (turn_on == true)
				Application.Idle += Application_Idle2;
			else
				MessageBox.Show("Please Start the WebCam");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			showSubmenu(panelWebcam);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Web_cam_Load(object sender, EventArgs e)
		{
			turn_on = false;
			capture = new VideoCapture(0);
			frame = new Mat();
		}
	}
}
