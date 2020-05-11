using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_SNT
{
	class Program
	{
		static void Main(string[] args)
		{
			TimNT a = new TimNT();
			Console.WriteLine("Tim so nguyen to cung c#:");
			a.Input();
			Console.WriteLine("Day so nguyen to trong mang:");
			a.Search();
			Console.ReadKey();
		}
	}
}
