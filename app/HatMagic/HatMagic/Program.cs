using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatMagic
{
	class Program
	{
		static void Main(string[] args)
		{
			Magic a = new Magic();
			Console.WriteLine("Welcom to Hat Magic!");
			a.Input();
			a.Output();
			Console.ReadKey();
		}
	}
}
