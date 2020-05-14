using System;

namespace Tuble_csharp
{
	class Program
	{
		static void Main(string[] args)
		{
			var tuble = Tuple.Create<int, string>(1, "Hello");

			Console.WriteLine(tuble.Item1 + "\t" + tuble.Item2);
			var now = GetCurrentDayMonthYear();
			Console.WriteLine(now.Item1 + " " + now.Item2 + " " + now.Item3);
			Console.WriteLine(now.ToString());
			Console.ReadLine();
		}
		static Tuple<int,int,int> GetCurrentDayMonthYear()
		{
			DateTime datetime = DateTime.Now;
			return new Tuple<int, int, int> (datetime.Day, datetime.Month, datetime.Year );
		}
	}
}
