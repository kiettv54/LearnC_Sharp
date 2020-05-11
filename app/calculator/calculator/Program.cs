using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			//chuong trinh tinh toan
			Console.WriteLine("Day la chuong trinh tinh toan!");
			Calculat a = new Calculat();
			a.Input();
			a.Output();
			Console.ReadKey();
		}
	}
}
