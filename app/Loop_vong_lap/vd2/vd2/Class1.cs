using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vd2
{
	class Class1
	{
		private int n;
		private int s = 0;
		public void nhap()
		{
			do
			{
				Console.Write("Enter N (N>=1):");
				n = int.Parse(Console.ReadLine());
				if (n < 1) Console.WriteLine("Error.Because n>=1!");
			} while (n < 1);

		}
		/// <summary>
		/// s=1^2+2^2+...+n^2;
		/// </summary>
		/// <returns></returns>
		public int tinhtong()
		{
			if (n == 1) return s = 1;
			else
			{
				for(int i=1;i<=n;i++)
				{
					s += i * i;
				}
			}
			return s;
		}
	}
}
