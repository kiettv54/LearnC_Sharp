using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_classwork
{
	class Class1
	{
		int n;
		int s = 0;
		public void Loop()
		{
			do
			{
				Console.Write("enter n:");
				n = int.Parse(Console.ReadLine());
				if (n < 1) Console.WriteLine("Error.Because n>=1!");
			} while (n < 1);

		}
		public int calculator()
		{
			if (n == 1) return s = 1;
			else
				for (int i = 1; i <= n; i++)
				{
					s += i;
				}
			return s;
		}
	}
}
