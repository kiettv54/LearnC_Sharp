using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vd2
{
	class Class2
	{
		private int n;
		float s = 0;
		public void Input()
		{
			do
			{
				Console.Write("Enter N (N>=1):");
				n = int.Parse(Console.ReadLine());
				if (n < 1)
					Console.WriteLine("Error.Because N>=1!");
			} while (n < 1);
		}
		public float Tinhs()
		{
			for(int i=1;i<=n;i++)
			{
				s += (float)1 / i;
			}
			return s;
		}
	}
}
