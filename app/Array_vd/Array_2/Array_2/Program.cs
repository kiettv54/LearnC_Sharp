using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Array a = new Array();
			a.Input();
			Console.WriteLine("Array List:");
			a.Output();
			a.Tinh();
			a.Tinh2();
			Console.WriteLine("\n Sum of Array List:{0}", a.Sum());
			
			Console.ReadKey();
		}
	}
}
