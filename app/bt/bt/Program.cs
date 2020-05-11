
using System;

namespace bt
{
	class Program
	{
		static void Main(string[] args)
		{
			Account account = new Account(3, "k");
			FindMaxPrimeNumber find = new FindMaxPrimeNumber();
			
			Console.WriteLine(account.Id);
			Console.WriteLine(account.Name);
			find.Input();
			Console.WriteLine("Max of 4 numbers:" + find.MaxPrime());
			Console.ReadLine();
		}
	}
}
