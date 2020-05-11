using System;
using System.Collections;

namespace ArrayList_CSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(new Person("Nguyen Van A", 17));
			arrayList.Add(new Person("Nguyen Van B", 19));
			arrayList.Add(new Person("Nguyen Van C", 15));
			arrayList.Add(new Person("Nguyen Van D", 20));
			foreach (var item in arrayList)	
			{
				Console.WriteLine(item);
			}
			arrayList.Sort(new SortPerson());
			foreach (var item in arrayList)
			{
				Console.WriteLine(item);
			}
			Console.ReadLine();
		}
	}
}
