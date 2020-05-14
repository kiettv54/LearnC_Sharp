using System;
using System.Collections;
using System.Collections.Generic;

namespace Dictionary_Csharp
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int,string> dictionary = new Dictionary<int,string>();
			dictionary.Add(1, "hello");
			dictionary.Add(2, "World");
			dictionary.Add(3, "I'm Kiet");
			Console.WriteLine("count number in dictionary: " + dictionary.Count);
			//ContainsKey check key exist in dictionary
			//ContainsValue check value exist in dictionary
			foreach (var item in dictionary)
			{
				Console.WriteLine(item.Key + "\t" + item.Value);
			}
			Console.ReadLine();
			
		}
	}
}
