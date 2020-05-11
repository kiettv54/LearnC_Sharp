using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DongHo
{
	class DH
	{
		DateTime now;
		public void Input()
		{
			int n = 0;
			while(n==0)
			{
				now = DateTime.Now;
				Console.WriteLine(now.ToLongTimeString());
				Console.WriteLine(now.ToShortDateString());
				Console.WriteLine(now.Year);
				Thread.Sleep(1000);
				Console.Clear();

			}

		}
	}
}
