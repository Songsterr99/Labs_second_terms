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

namespace ProcessEvents
{
	public partial class Demonstrator : Form
	{
		public delegate void ControlCalculations();
		public event ControlCalculations StartCalc;
		public event ControlCalculations StopCalc;
		Calculator calc;
		public Demonstrator()
		{
			InitializeComponent();
		}

		private void Show(int n, int k, int result)
		{
			Action action = () =>
			{
				lStirlingNumber.Text = "(" + n.ToString() + ", " + k.ToString() + ")";
				lAnswer.Text = result.ToString();
			};
			Invoke(action);
		}

		private void Demonstrator_Load(object sender, EventArgs e)
		{
			calc = new Calculator(1000);
			calc.CalculateEvents += new CalculationResult(Show);
			StopCalc += new ControlCalculations(calc.Stop);
			StartCalc += new ControlCalculations(calc.Start);

		}

		private void bStart_Click(object sender, EventArgs e)
		{
			StartCalc();
			Thread thread = new Thread(calc.StartCalculate);
			thread.Start();
			bStart.Enabled = false;
		}

		private void bStop_Click(object sender, EventArgs e)
		{
			lStirlingNumber.Text = "(0, 0)";
			lAnswer.Text = "0";
			StopCalc();
			bStart.Enabled = true;
		}

		private void Demonstrator_FormClosed(object sender, FormClosedEventArgs e)
		{
			StopCalc();
		}
	}
}
