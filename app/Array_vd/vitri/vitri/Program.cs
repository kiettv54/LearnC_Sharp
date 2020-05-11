using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vitri
{
	class Program
	{
		static void Main(string[] args)
		{
			Array a = new Array();
			a.Input();
			Console.WriteLine("Array List:");
			a.Output();
			Console.WriteLine("\nSearch exam x:");
			a.SearchX();
			Console.WriteLine("Array B then copy:");
			a.CopyArray();
			Console.ReadKey();
		}
	}
}
