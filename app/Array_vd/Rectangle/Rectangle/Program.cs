using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
	class Program
	{
		static void Main(string[] args)
		{
			/*Rectangle1 a = new Rectangle1();
			a.Input();
			Console.WriteLine("Rectangle:");
			a.Output();*/
			Tamgiac b = new Tamgiac();
			b.Input1();
			Console.WriteLine("Triangle:");
			b.Output1();
			Console.ReadKey();
		}
	}
}
