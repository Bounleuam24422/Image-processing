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
	public partial class Main : Form
	{
		public Main()
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
			lblTitle.Text = childForm.Text;
			panelMain.Controls.Add(childForm);
			panelMain.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		/* panelSlide*/
		private void customizeDesing()
		{
			panalFilter_Type.Visible = false;
		}

		/* hideSubmenu*/
		private void hideSubmenu()
		{
			if (panalFilter_Type.Visible == true)
				panalFilter_Type.Visible = false;

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


		private void btnFilter_Click(object sender, EventArgs e)
		{
			
		}

		private void btnbinary_Click(object sender, EventArgs e)
		{

		}

		private void btnMlogy_Click(object sender, EventArgs e)
		{

		}

		private void btnEdDtion_Click(object sender, EventArgs e)
		{

		}

		private void btnHisgm_Click(object sender, EventArgs e)
		{

		}

		private void btnCntour_Click(object sender, EventArgs e)
		{

		}

		private void btnWebcam_Click(object sender, EventArgs e)
		{

		}


		private void btnHisgm(object sender, EventArgs e)
		{

		}

		private void btnClose_Click(object sender, EventArgs e)
		{

		}

		private void btnFilter_Click_2(object sender, EventArgs e)
		{
			openChildForm(new FiltersModule());
		}

		private void btnbinary_Click_1(object sender, EventArgs e)
		{
			openChildForm(new BinaryModule());
		}

		private void btnFter_Typ_Click(object sender, EventArgs e)
		{
			showSubmenu(panalFilter_Type);
		}
	}
}
