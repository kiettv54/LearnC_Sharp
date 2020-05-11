using System;
using System.Reflection.Metadata.Ecma335;

namespace ClassAbstract
{
	class Program
	{
		static void Main(string[] args)
		{
			Animal cat = new Cat();
			cat.Speak();
			Console.ReadLine();

		}
	}
}
