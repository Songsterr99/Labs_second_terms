using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace LastTarget
{
	public partial class Form1 : Form
	{
		public delegate void ReceiveEvent();
		public event ReceiveEvent StartFire;
		public event ReceiveEvent StopFire;
		public event ReceiveEvent StopFire2;


		int R = 0, alpha = 0, patrons = 0;
		bool isReady = false;
		CreateEvent ce;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			BackColor = Color.Azure;
			pFire.Location = new Point(124, 16);
		}

		private void FireEvent(int x, int y)
		{
			Action action = () =>
			{
				tbX.Text = x.ToString();
				tbY.Text = y.ToString();
				Fire(x, y);
			};
			Invoke(action);
		}

		private void bNewGame_Click(object sender, EventArgs e)
		{
			try
			{
				Graphics g = CreateGraphics();
				patrons = Int32.Parse(tbPatrons.Text);
				R = Int32.Parse(tbRadius.Text);
				alpha = Int32.Parse(tbAlpha.Text);
				lPat.Text = tbPatrons.Text;
				if (R > Height / 2 || R > Width / 2 || alpha > 90 || alpha < 0)
					return;
				ChangeVisible();
				drawTarget(DisplayRectangle, g);
				isReady = !isReady;
				if(isReady)
				{
					StartThreadFire();

				}

			}
			catch (Exception m)
			{
				MessageBox.Show(m.Message);
				return;
			}
		}

		private void StartThreadFire()
		{
			ce = new CreateEvent(1, patrons, R, R);
			StartFire += new ReceiveEvent(ce.Start);
			StopFire += new ReceiveEvent(ce.Stop);

			ce.CoordinatesEvent += new EventResult(FireEvent);
			StartFire();
			Thread thread = new Thread(ce.StartCalculate);
			thread.Start();

			StopFire2 += new ReceiveEvent(ce.Stop2);
			ce.CalculateEvents += new CalculationResult(Show);
			Thread thread2 = new Thread(ce.StartCalculateNumber);
			thread2.Start();
		}

		private void Show(long n, long k, long result)
		{
			Action action = () =>
			{
				lStirlingNumber.Text = "(" + n.ToString() + ", " + k.ToString() + ")";
				lAnswer.Text = result.ToString();
			};
			Invoke(action);
		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			Invalidate();
		}

		private void ChangeVisible()
		{
			pFire.Visible = !pFire.Visible;
			pNewGame.Visible = !pNewGame.Visible;
			bStop.Visible = !bStop.Visible;
			bStop2.Visible = !bStop2.Visible;
			bNewGame.Visible = !bNewGame.Visible;
		}

		private void Fire(int x, int y)
		{
			Graphics g = CreateGraphics();
			Brush red = new SolidBrush(Color.FromArgb(244, 66, 80));
			patrons = Int32.Parse(lPat.Text);
			lPat.Text = (--patrons).ToString();
			g.FillEllipse(red, Width / 2 + x - 3, Height / 2 - y - 3, 6, 6);
			if (Aim(x, y))
			{
				int hits = Int32.Parse(lHits.Text);
				lHits.Text = (++hits).ToString();
			}
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


		private void Form_Closed(object sender, FormClosedEventArgs e)
		{
			StopFire();
			StopFire2();
		}

		private void bStop_Click(object sender, EventArgs e)
		{
			StopFire();
			ChangeVisible();
			isReady = !isReady;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			StopFire2();
		}

		private void drawTarget(Rectangle r, Graphics g)
		{
			g.Clear(Color.Azure);
			Brush black = new SolidBrush(Color.FromArgb(61, 73, 91));
			g.FillPie(black, Width / 2 - R, Height / 2 - R, 2 * R, 2 * R, 270, 90 - alpha);
			g.FillPie(black, Width / 2 - R, Height / 2 - R, 2 * R, 2 * R, 90, 90 - alpha);
			g.Dispose();
			black.Dispose();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			if(isReady)
				drawTarget(ClientRectangle, e.Graphics);
			
			
		}
	}
}
