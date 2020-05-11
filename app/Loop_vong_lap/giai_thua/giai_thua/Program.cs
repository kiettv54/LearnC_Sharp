using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giai_thua
{
	class Program
	{
		static void Main(string[] args)
		{
			GT a = new GT();
			Console.WriteLine("s=1*2*3*...*n=n!");
			a.Input();
			Console.WriteLine(a.tas()+"!=" + a.Tinh());
			Console.ReadKey();
		}
	}
}
