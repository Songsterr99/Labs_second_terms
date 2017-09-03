using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LastTarget
{
	public delegate void EventResult(int x, int y);
	public delegate void CalculationResult(long n, long k, long result);
	class CreateEvent
	{
		public event CalculationResult CalculateEvents;
		public event EventResult CoordinatesEvent;
		int time,
			patrons,
			maxX,
			maxY;
		long k,
			 result,
			 n;
		bool work = false,
			 work2 = false;
		Random rnd;

		public CreateEvent(int time, int patrons, int maxX, int maxY)
		{
			this.time = time;
			this.patrons = patrons;
			this.maxX = maxX;
			this.maxY = maxY;
			rnd = new Random();
		}

		long CalculateNumber(long n, long k)
		{
			if (n == 0 && k == 0)
				return 1;
			else if ((n == 0 && k != 0) || (n != 0 && k == 0))
				return 0;

			long result = CalculateNumber(n - 1, k - 1) - (n - 1) * CalculateNumber(n - 1, k);
			return result;
		}

		public void StartCalculateNumber()
		{
			while (work && work2)
			{
				n = rnd.Next(0, 10);
				k = rnd.Next(0, (int)n);
				result = CalculateNumber(n, k);
				if (CalculateEvents != null)
					CalculateEvents(n, k, result);
				Thread.Sleep(time);
			}
		}


		public void StartCalculate()
		{
			for (int i = 0; i < patrons; i++)
			{
				if (work )
				{
					int x = rnd.Next(-maxX, maxX);
					int y = rnd.Next(-maxY, maxY);
					if (CoordinatesEvent != null)
						CoordinatesEvent(x, y);
					Thread.Sleep(time);

				}
					
			}
		}


		public void Stop()
		{
			work = false;
		}

		public void Stop2()
		{
			work2 = false;
		}

		public void Start()
		{
			work = true;
			work2 = true;
		}
	}
}
