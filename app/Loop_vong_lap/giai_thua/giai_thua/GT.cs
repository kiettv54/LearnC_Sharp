using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giai_thua
{
	class GT
	{
		int n;
		int s = 1;
		public void Input()
		{
			do
			{
				Console.Write("Enter N (N>=0):");
				n = int.Parse(Console.ReadLine());
				if (n < 0 )
					Console.WriteLine("Error.Because N>=0 and N must is Integer !");
			} while (n < 0 );
		}
		public int Tinh()
		{
			if (n == 0 || n == 1) return s;
			else
			{
				for(int i=1;i<=n;i++)
				{
					s *= i;
				}
			}
			return s;
		}
		public int tas()
		{
			return n;
		}
	}
}
