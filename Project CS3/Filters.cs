using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using AForge.Imaging.Filters;
using System.Drawing.Drawing2D;
using AForge.Imaging;
using Emgu.CV;


namespace Project_CS3
{
	public partial class FiltersModule : Form
	{
		public FiltersModule()
		{
			InitializeComponent();
			customizeDesing();
		}
		System.Drawing.Image file;
		Boolean opened = false;

		private Form activeForm = null;
		public void openChildForm(Form childForm)
		{
			if (activeForm != null)
				activeForm.Close();
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			//lblTitle.Text = childForm.Text;
			panelSubfilters.Controls.Add(childForm);
			panelSubfilters.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		/* panelSlide*/
		private void customizeDesing()
		{
			panelSubfilters.Visible = false;
		}

		/* hideSubmenu*/
		private void hideSubmenu()
		{
			if (panelSubfilters.Visible == true)
				panelSubfilters.Visible = false;

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
		void reload()
		{
			if (!opened)
			{
				MessageBox.Show("Error: Please open an image first");
			}

			else
			{

				pictureBox2.Width = 720;
				pictureBox2.Height = 480;

				pictureBox2.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
				file = pictureBox2.Image;
				opened = true;
			}
		}
		void saveImage()
		{
			if (opened)
			{
				SaveFileDialog sfd = new SaveFileDialog();

				sfd.Filter = "Images|*.png;*.bmp;*.jpg";
				ImageFormat format = ImageFormat.Png;

				if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					string ext = Path.GetExtension(sfd.FileName);

					switch (ext)
					{
						case ".jpg":
							format = ImageFormat.Jpeg;
							break;

						case ".bmp":
							format = ImageFormat.Bmp;
							break;
					}

					pictureBox2.Image.Save(sfd.FileName, format);
				}
			}

			else
				MessageBox.Show("No image loaded, please upload image");
		}
		void openImage()
		{
			DialogResult dr = openFileDialog1.ShowDialog();

			if (dr == DialogResult.OK)
			{
				file = System.Drawing.Image.FromFile(openFileDialog1.FileName);
				pictureBox2.Image = file;
				opened = true;
			}
		}


		void sepia()
		{
			if (!opened)
			{
				MessageBox.Show("Open an Image then apply changes");
			}
			else
			{

				System.Drawing.Image img = pictureBox2.Image;                            
				Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   

				ImageAttributes ia = new ImageAttributes();                 
				ColorMatrix cmPicture = new ColorMatrix(new float[][]       
                {
					new float[]{0.393f, 0.349f, 0.272f, 0, 0},
					new float[]{0.769f, 0.686f, 0.534f, 0, 0},
					new float[]{.189f, .168f, .131f, 0, 0},
					new float[]{0, 0, 0, 1, 0},
					new float[]{0, 0, 0, 0, 1}
				});
				ia.SetColorMatrix(cmPicture);           
				Graphics g = Graphics.FromImage(bmpInverted);  
				g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


				


				g.Dispose();                           
				pictureBox2.Image = bmpInverted;

			}
		}

		void grayscale()
		{
			if (!opened)
			{
				MessageBox.Show("Open an Image then apply changes");
			}
			else
			{

				System.Drawing.Image img = pictureBox2.Image;                           
				Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   

				ImageAttributes ia = new ImageAttributes();                 
				ColorMatrix cmPicture = new ColorMatrix(new float[][]       
                {
					new float[]{0.33f, 0.33f, 0.33f, 0, 0},
					new float[]{0.59f, 0.59f, 0.59f, 0, 0},
					new float[]{0.11f, 0.11f, 0.11f, 0, 0},
					new float[]{0, 0, 0, 1, 0},
					new float[]{0, 0, 0, 0, 1}
				});
				ia.SetColorMatrix(cmPicture);           
				Graphics g = Graphics.FromImage(bmpInverted);   

				g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


				


				g.Dispose();                            
				pictureBox2.Image = bmpInverted;

			}
		}

		void invert()
		{
			if (!opened)
			{
				MessageBox.Show("Open an Image then apply changes");
			}
			else
			{

				System.Drawing.Image img = pictureBox2.Image;                            
				Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   
                                                                        

				ImageAttributes ia = new ImageAttributes();                 
				ColorMatrix cmPicture = new ColorMatrix(new float[][]      
                {
					new float[]{-1, 0, 0, 0, 1.00f},
					new float[]{0, -1, 0, 0, 1.00f},
					new float[]{0, 0, -1, 0, 1.00f},
					new float[]{0, 0, 0, 1, 0},
					new float[]{1, 1, 1, 0, 1}
				});
				ia.SetColorMatrix(cmPicture);           
				Graphics g = Graphics.FromImage(bmpInverted);  

				g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);




				g.Dispose();                           
				pictureBox2.Image = bmpInverted;

			}
		}

		void rbgTobgr()
		{
			if (!opened)
			{
				MessageBox.Show("Open an Image then apply changes");
			}
			else
			{

				System.Drawing.Image img = pictureBox2.Image;                             
				Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   
                                                                        

				ImageAttributes ia = new ImageAttributes();                 
				ColorMatrix cmPicture = new ColorMatrix(new float[][]       
                {
					new float[]{0, 0, 1, 0, 0},
					new float[]{0, 1, 0, 0, 0},
					new float[]{1, 0, 0, 0, 0},
					new float[]{0, 0, 0, 1, 0},
					new float[]{0, 0, 0, 0, 1}
				});
				ia.SetColorMatrix(cmPicture);          
				Graphics g = Graphics.FromImage(bmpInverted);   

				g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


				


				g.Dispose();                            
				pictureBox2.Image = bmpInverted;

			}
		}

		void blackAndWhite()
		{
			if (!opened)
			{
				MessageBox.Show("Open an Image then apply changes");
			}
			else
			{

				System.Drawing.Image img = pictureBox2.Image;                             
				Bitmap bmpInverted = new Bitmap(img.Width, img.Height); 

				ImageAttributes ia = new ImageAttributes();                 
				ColorMatrix cmPicture = new ColorMatrix(new float[][]       
                {
					new float[]{1.5f, 1.5f, 1.5f, 0, 0},
					new float[]{1.5f, 1.5f, 1.5f, 0, 0},
					new float[]{1.5f, 1.5f, 1.5f, 0, 0},
					new float[]{0, 0, 0, 1, 0},
					new float[]{-1, -1, -1, 0, 1}
				});
				ia.SetColorMatrix(cmPicture);           
				Graphics g = Graphics.FromImage(bmpInverted);   
				g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


				


				g.Dispose();                            
				pictureBox2.Image = bmpInverted;

			}
		}

		void polaroid()
		{
			if (!opened)
			{
				MessageBox.Show("Open an Image then apply changes");
			}
			else
			{

				System.Drawing.Image img = pictureBox2.Image;                             
				Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   
                                                                        

				ImageAttributes ia = new ImageAttributes();                 
				ColorMatrix cmPicture = new ColorMatrix(new float[][]       
                {
					new float[]{1.438f, -0.062f, -0.062f, 0, 0},
					new float[]{-0.122f, 1.378f, -0.122f, 0, 0},
					new float[]{-0.016f, -0.016f, 1.483f, 0, 0},
					new float[]{0, 0, 0, 1, 0},
					new float[]{-0.03f, 0.05f, -0.02f, 0, 1}
				});
				ia.SetColorMatrix(cmPicture);          
				Graphics g = Graphics.FromImage(bmpInverted);   

				g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


				


				g.Dispose();                           
				pictureBox2.Image = bmpInverted;

			}
		}

		void ccorrect()
		{
			if (!opened)
			{
				MessageBox.Show("Open an Image then apply changes");
			}
			else
			{

				System.Drawing.Image img = pictureBox2.Image;                            
				Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   
                                                                       

				ImageAttributes ia = new ImageAttributes();
				
				ColorMatrix cmPicture = new ColorMatrix(new float[][]      
                {
					new float[]{1, 0, 0, 0, 0},
					new float[]{0, 0.8f, 0, 0, 0},
					new float[]{0, 0, 0.5f, 0, 0},
					new float[]{0, 0, 0, 0.5f, 0},
					new float[]{0, 0, 0, 0, 1}
				});
				ia.SetColorMatrix(cmPicture);           
				Graphics g = Graphics.FromImage(bmpInverted);   

				g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


				


				g.Dispose();                            
				pictureBox2.Image = bmpInverted;

			}
		}

		void checkf()
		{
			if (!opened)
			{
				MessageBox.Show("Open an Image then apply changes");
			}
			else
			{

				System.Drawing.Image img = pictureBox2.Image;                             
				Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   
                                                                       
				ImageAttributes ia = new ImageAttributes();
				
				ColorMatrix cmPicture = new ColorMatrix(new float[][]       
                {
					new float[]{1, 0, 0, 0, 0},
					new float[]{0, 0.8f, 0, 0, 0},
					new float[]{0, 0, 0.5f, 0, 0},
					new float[]{0, 0, 0, 0.5f, 0},
					new float[]{0, 0, 0, 0, 1}
				});
				ia.SetColorMatrix(cmPicture);          
				Graphics g = Graphics.FromImage(bmpInverted);   

				g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


				


				g.Dispose();                            
				pictureBox2.Image = bmpInverted;

			}
		}

		System.Drawing.Image zoom(System.Drawing.Image img, Size size)
		{
			Bitmap bmp = new Bitmap(img, img.Width + (img.Width * size.Width / 100), img.Height + (img.Height * size.Height / 100));
			Graphics g = Graphics.FromImage(bmp);
			g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
			return bmp;
		}


		void crop()
		{
			Cursor = Cursors.Default;



			if (cropWidth < 1)
			{

				return;

			}

			Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);

			

			Bitmap OriginalImage = new Bitmap(pictureBox2.Image, pictureBox2.Width, pictureBox2.Height);

	

			Bitmap _img = new Bitmap(cropWidth, cropHeight);

			

			Graphics g = Graphics.FromImage(_img);

	

			g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

			g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

			g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

		

			g.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel);



			pictureBox2.Image = _img;

			pictureBox2.Width = _img.Width;

			pictureBox2.Height = _img.Height;

	

			btnCrop.Enabled = false;
		}

		void brightness()
		{
			float changeb = trackBar1.Value * 0.1f;
			float changec = trackBar2.Value * 0.1f;
			float changes = trackBar3.Value * 0.1f;
		

			trackBar1.Text = changeb.ToString();
			trackBar2.Text = changec.ToString();
			trackBar3.Text = changes.ToString();

			reload();
			if (!opened)
			{
			}
			else
			{



				System.Drawing.Image img = pictureBox2.Image;                             
				Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   
                                                                        

				ImageAttributes ia = new ImageAttributes();                 
				ColorMatrix cmPicture = new ColorMatrix(new float[][]       
                {
					new float[]{1, 0, 0, 0, 0},
					new float[]{0, 1, 0, 0, 0},
					new float[]{0, 0, 1, 0, 0},
					new float[]{0, 0, 0, 1, 0},
					new float[]{0+changeb, 0+changeb, 0+changeb, 0, 1}
				});
				ia.SetColorMatrix(cmPicture);           
				Graphics g = Graphics.FromImage(bmpInverted);   

				g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


				


				g.Dispose();                            
				pictureBox2.Image = bmpInverted;


			}
		}

		void contrast()
		{
			float changeb = trackBar1.Value * 0.1f;
			float changec = trackBar2.Value * 0.1f;
			float changes = trackBar3.Value * 0.1f;
			float t = 0;
			

			trackBar1.Text = changeb.ToString();
			trackBar2.Text = changec.ToString();
			trackBar3.Text = changes.ToString();

			reload();
			if (!opened)
			{
			}
			else
			{



				System.Drawing.Image img = pictureBox2.Image;                             
				Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   
                                                                        

				ImageAttributes ia = new ImageAttributes();                 
				ColorMatrix cmPicture = new ColorMatrix(new float[][]      
                {
					new float[]{1+changec, 0, 0, 0, 0},
					new float[]{0, 1+changec, 0, 0, 0},
					new float[]{0, 0, 1+changec, 0, 0},
					new float[]{0, 0, 0, 1, 0},
					new float[]{t, t, t, 0, 1}
				});

				if (changec == 0)
					t = (1f - changec) / 2f;

				ia.SetColorMatrix(cmPicture);           
				Graphics g = Graphics.FromImage(bmpInverted);   
				g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);




				g.Dispose();                            
				pictureBox2.Image = bmpInverted;


			}
		}

		void saturation()
		{
			float changeb = trackBar1.Value * 0.1f;
			float changec = trackBar2.Value * 0.1f;
			float changes = trackBar3.Value * 0.1f;
			

			float lumR = 0.3086f;

			float lumG = 0.6094f;

			float lumB = 0.0820f;
			float sr = (1 - changes) * lumR;

			float sg = (1 - changes) * lumG;

			float sb = (1 - changes) * lumB;



			trackBar1.Text = changeb.ToString();
			trackBar2.Text = changec.ToString();
			trackBar3.Text = changes.ToString();

			reload();
			if (!opened)
			{
			}
			else
			{



				System.Drawing.Image img = pictureBox2.Image;                             
				Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   
                                                                        

				ImageAttributes ia = new ImageAttributes();                 
				ColorMatrix cmPicture = new ColorMatrix(new float[][]       
                {
					new float[]{sr+changes, sr, sr, 0, 0},
					new float[]{sg, sg+changes, sg, 0, 0},
					new float[]{sb, sb, sb+changes, 0, 0},
					new float[]{0, 0, 0, 1, 0},
					new float[]{0, 0, 0, 0, 1}
				});
				ia.SetColorMatrix(cmPicture);           
				Graphics g = Graphics.FromImage(bmpInverted);   
				g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


				


				g.Dispose();                            
				pictureBox2.Image = bmpInverted;


			}
		}
		int cropX;
		int cropY;
		int cropWidth;
		int cropHeight;
		int oCropX;
		int oCropY;
		Pen cropPen;
		DashStyle cropDashStyle = DashStyle.DashDot;

		void movedown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btnCrop.Enabled = true;

			if (e.Button == System.Windows.Forms.MouseButtons.Left)
			{
				Cursor = Cursors.Cross;

				cropX = e.X;
				cropY = e.Y;

				cropPen = new Pen(Color.Black, 1);

				cropPen.DashStyle = DashStyle.DashDotDot;
			}

			pictureBox2.Refresh();
		}



		void move(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btnCrop.Enabled = true;

			if (pictureBox2.Image == null)
				return;

			if (e.Button == System.Windows.Forms.MouseButtons.Left)
			{
				pictureBox2.Refresh();
				cropWidth = e.X - cropX;
				cropHeight = e.Y - cropY;

				try
				{
					pictureBox2.CreateGraphics().DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight);
				}

				catch (ArgumentNullException)
				{

				}
			}
		}
		void smooth()
		{
			if (pictureBox2.Image == null)
			{
				MessageBox.Show("Please open an image first");
				return; // Exit the method if pictureBox2 is empty
			}

			System.Drawing.Bitmap image = (Bitmap)pictureBox2.Image;
			AForge.Imaging.Filters.ConservativeSmoothing filter = new AForge.Imaging.Filters.ConservativeSmoothing();
			pictureBox2.Image = filter.Apply(image);
		

		}

		void sepia1()
		{
			if (pictureBox2.Image == null)
			{
				MessageBox.Show("Please open an image first");
				return; // Exit the method if pictureBox2 is empty
			}

			System.Drawing.Bitmap image = (Bitmap)pictureBox2.Image;
			AForge.Imaging.Filters.Sepia filter = new AForge.Imaging.Filters.Sepia();
			pictureBox2.Image = filter.Apply(image);
		
		}

		void GaussianSharp()
		{

			if (pictureBox2.Image == null)
			{
				MessageBox.Show("Please open an image first");
				return; // Exit the method if pictureBox2 is empty
			}

			System.Drawing.Bitmap image = (Bitmap)pictureBox2.Image;
			AForge.Imaging.Filters.GaussianSharpen filter = new AForge.Imaging.Filters.GaussianSharpen();
			pictureBox2.Image = filter.Apply(image);


		}

		void WaterWavef()
		{
			if (pictureBox2.Image == null)
			{
				MessageBox.Show("Please open an image first");
				return; // Exit the method if pictureBox2 is empty
			}

			System.Drawing.Bitmap image = (Bitmap)pictureBox2.Image;
			AForge.Imaging.Filters.WaterWave filter = new AForge.Imaging.Filters.WaterWave();
			filter.HorizontalWavesCount = 10;
			filter.HorizontalWavesAmplitude = 5;
			filter.VerticalWavesCount = 3;
			filter.VerticalWavesAmplitude = 15;
			pictureBox2.Image = filter.Apply(image);
		

		}

		void Sharp()
		{
			if (pictureBox2.Image == null)
			{
				MessageBox.Show("Please open an image first");
				return; // Exit the method if pictureBox2 is empty
			}

			System.Drawing.Bitmap image = (Bitmap)pictureBox2.Image;
			AForge.Imaging.Filters.Sharpen filter = new AForge.Imaging.Filters.Sharpen();
			pictureBox2.Image = filter.Apply(image);
			

		}

		private void button13_Click(object sender, EventArgs e)
		{
			reload();
			sepia1();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			reload();
			sepia();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			reload();
			grayscale();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			reload();
			invert();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			reload();
			rbgTobgr();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			reload();
			blackAndWhite();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			reload();
			polaroid();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			smooth();
		}

		private void button15_Click(object sender, EventArgs e)
		{
			WaterWavef();
		}

		private void button12_Click(object sender, EventArgs e)
		{
			ccorrect();
		}

		private void button14_Click(object sender, EventArgs e)
		{
			GaussianSharp();
		}

		private void button16_Click(object sender, EventArgs e)
		{
			Sharp();
		}

		private void btnCrop_Click(object sender, EventArgs e)
		{
			crop();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			reload();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			openImage();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			saveImage();
		}

		private void button11_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Note: Remember to save image in the computer first.");
			System.Diagnostics.Process.Start("https://www.dropbox.com/home");
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{

		}

		private void trackBar2_Scroll(object sender, EventArgs e)
		{

		}

		private void trackBar3_Scroll(object sender, EventArgs e)
		{

		}

		

		private void Filters_Load(object sender, EventArgs e)
		{
			pictureBox2.ContextMenu = new ContextMenu();

			pictureBox2.MouseDown += new MouseEventHandler(movedown);
			pictureBox2.MouseMove += new MouseEventHandler(move);
		}

		private void trackBar1_ValueChanged(object sender, EventArgs e)
		{
			brightness();
		}

		private void trackBar2_ValueChanged(object sender, EventArgs e)
		{
			contrast();
		}

		private void trackBar3_ValueChanged(object sender, EventArgs e)
		{
			saturation();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox15_Click(object sender, EventArgs e)
		{
			
			reload();
			sepia1();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			reload();
			sepia();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			reload();
			grayscale();
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			reload();
			invert();
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			reload();
			rbgTobgr();
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			reload();
			blackAndWhite();
		}

		private void pictureBox8_Click(object sender, EventArgs e)
		{

			reload();
			polaroid();
		}

		private void pictureBox9_Click(object sender, EventArgs e)
		{
			smooth();
		}

		private void pictureBox10_Click(object sender, EventArgs e)
		{
			WaterWavef();
		}

		private void pictureBox12_Click(object sender, EventArgs e)
		{
			ccorrect();
		}

		private void pictureBox11_Click(object sender, EventArgs e)
		{
			GaussianSharp();
		}

		private void pictureBox13_Click(object sender, EventArgs e)
		{
			Sharp();
		}

		private void btnCrop_Click_1(object sender, EventArgs e)
		{
			crop();
		}

		private void pictureBox14_Click(object sender, EventArgs e)
		{
			crop();
		}

		private void btnCrop_Click_2(object sender, EventArgs e)
		{

		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			showSubmenu(panelSubfilters);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
