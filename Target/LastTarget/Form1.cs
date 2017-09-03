using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastTarget
{
	public partial class Form1 : Form
	{
		int R,
			alpha,
			patrons;
		bool isReady = false,
			 isReadyFire = false;
		List<Point> listOfPatrons;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			BackColor = Color.Azure;
			pFire.Location = new Point(124, 16);
		}

		private void bNewGame_Click(object sender, EventArgs e)
		{
			try
			{
				listOfPatrons = new List<Point>();
				Graphics g = CreateGraphics();
				R = Int32.Parse(tbRadius.Text);
				alpha = Int32.Parse(tbAlpha.Text);
				lPat.Text = tbPatrons.Text;
				if (R > Height / 2 || R > Width / 2 || alpha > 90 || alpha < 0)
					return;
				drawTarget(DisplayRectangle, g);
				ChangeVisible();
				
			}
			catch (Exception m)
			{
				MessageBox.Show(m.Message);
				return;
			}
			isReady = !isReady;
		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			Invalidate();
		}

		private void ChangeVisible()
		{
			pFire.Visible = !pFire.Visible;
			pNewGame.Visible = !pNewGame.Visible;
			bFire.Visible = !bFire.Visible;
		}

		private void bFire_Click(object sender, EventArgs e)
		{
			try
			{
				Graphics g = CreateGraphics();
				patrons = Int32.Parse(lPat.Text);
				if(patrons == 0)
					Application.Restart();
				lPat.Text = (--patrons).ToString();
				int x = Int32.Parse(tbX.Text),
					y = Int32.Parse(tbY.Text);
				Point p = new Point(x, y);
				listOfPatrons.Add(p);
				drawPatrons(DisplayRectangle, g, x, y);
				isReadyFire = true;
				if (Aim(x, y))
				{
					int hits = Int32.Parse(lHits.Text);
					lHits.Text = (++hits).ToString();
				}

			}
			catch (Exception m)
			{
				MessageBox.Show(m.Message);
				return;
			}
		}

		private void drawPatrons(Rectangle r, Graphics g, int x, int y)
		{
			
			Brush red = new SolidBrush(Color.FromArgb(244, 66, 80));
		    g.FillRectangle(red, Width / 2 + x - 3, Height / 2 - y - 3, 6, 6);
		}

		private bool Aim(int x, int y)
		{
			if (y < 0)
			{
				y = -y;
				x = -x;
			}

			double radians = Math.Atan((double)y / (double)x);
			double angle = radians * (180 / Math.PI);
			if (Math.Sqrt(x * x + y * y) > R || alpha > angle )
				return false;
			return true;
		}

		private void drawTarget(Rectangle r, Graphics g)
		{
			patrons = Int32.Parse(tbPatrons.Text);
			g.Clear(Color.Azure);
			Brush black = new SolidBrush(Color.FromArgb(61, 73, 91));
			g.FillPie(black, Width / 2 - R, Height / 2 - R, 2 * R, 2 * R, 270, 90 - alpha);
			g.FillPie(black, Width / 2 - R, Height / 2 - R, 2 * R, 2 * R, 90, 90 - alpha);
			//g.Dispose();
			black.Dispose();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			if(isReady)
			{
				drawTarget(ClientRectangle, e.Graphics);
				for (int i = 0; i < listOfPatrons.Count; i++)
				{
					if (!isReadyFire)
						return;
					int x = listOfPatrons[i].X,
						y = listOfPatrons[i].Y;
					drawPatrons(ClientRectangle, e.Graphics, x, y);
					
				}
			}
		}
	}
}
