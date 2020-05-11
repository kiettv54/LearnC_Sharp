using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vd2
{
	class Program
	{
		static void Main(string[] args)
		{
			Class1 a = new Class1();
			a.nhap();
			Console.WriteLine("s=1^2+2^2+..+n^n is:" + a.tinhtong());
			Class2 b = new Class2();
			b.Input();
			Console.WriteLine("s=1+1/2+...+1/n is:" + b.Tinhs());
			Console.ReadKey();
		}
	}
}
