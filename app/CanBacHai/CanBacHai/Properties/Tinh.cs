using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanBacHai.Properties
{
	class Tinh
	{
		double a;
		public void Input()
		{
			do
			{
				Console.Write("Enter a:");
				a = double.Parse(Console.ReadLine());
				if (a < 0)
					Console.WriteLine("Error.Because a >=0.invite to re - enter!");
			} while (a < 0);
		}
		public double Output()
		{
			double kq;
			kq = Math.Sqrt(a);
			return kq;
		}
	}
}
