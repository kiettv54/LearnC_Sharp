using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sohoanhao
{
	class Program
	{
		static void Main(string[] args)
		{
			Tinh a = new Tinh();
			a.Input();
			Console.WriteLine("Number List: ");
			a.Tinhs();
			Console.ReadKey();
		}
	}
}
