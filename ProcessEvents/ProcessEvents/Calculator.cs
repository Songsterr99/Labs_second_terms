using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProcessEvents
{
	public delegate void CalculationResult(int n, int k, int result);
	class Calculator
	{
		public event CalculationResult CalculateEvents;
		int time,
			k,
			result,
			n;
		bool flags = false;
		Random rnd;

		public Calculator(int time)
		{
			this.time = time;
			rnd = new Random();
		}

		int CalculateNumber(int n, int k)
		{
			if (n == 0 && k == 0)
				return 1;
			else if ((n == 0 && k != 0) || (n != 0 && k == 0))
				return 0;
			
			int result = CalculateNumber(n - 1, k - 1) - (n - 1) * CalculateNumber(n - 1, k );
			return result;
		}


		public void StartCalculate()
		{
			while(flags)
			{
				n = rnd.Next(0, 20);
				k = rnd.Next(0, n);
				result = CalculateNumber(n, k);
				if (CalculateEvents != null)
					CalculateEvents(n, k, result);
				Thread.Sleep(time);
			}
		}

		public void Stop()
		{
			flags = false;
		}

		public void Start()
		{
			flags = true;
		}
	}
}
