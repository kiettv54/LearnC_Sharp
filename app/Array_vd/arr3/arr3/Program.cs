using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arr3
{
	class Program
	{
		static void Main(string[] args)
		{
			Array a = new Array();
			a.Input();
			Console.WriteLine("Array List:");
			a.Output();
			Console.WriteLine("\nMax number of Array List:{0}", a.search_max());
			Console.WriteLine("SelectionSort Array List:");
						a.SelectionSort();
						a.Output();
			
						Console.WriteLine("Array List after Deleting:");
						a.Delete();
						a.Output();
	
		Console.ReadKey();
		}
	}
}
