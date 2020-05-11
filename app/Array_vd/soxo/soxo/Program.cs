using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soxo
{
	class Program
	{
		static void Main(string[] args)
		{
			XoSo a = new XoSo();
			Console.WriteLine("Welcom to so xo!");
			a.Input();
			a.Output();
			Console.ReadKey();
		}
	}
}
