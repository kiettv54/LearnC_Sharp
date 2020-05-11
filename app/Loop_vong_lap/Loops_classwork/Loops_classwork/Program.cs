using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_classwork
{
	class Program
	{
		static void Main(string[] args)
		{
			Class1 a = new Class1();
			a.Loop();
			Console.WriteLine("s=1+2+3+...+n is:" + a.calculator());
			Console.ReadKey();
		}
	}
}
