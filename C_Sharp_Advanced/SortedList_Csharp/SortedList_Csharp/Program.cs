using System;
using System.Collections;

namespace SortedList_Csharp
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			 SortedLisst như hashtable
			 các giá trị được sắp xếp theo key một cách tự động mỗi khi thêm 1 phần tử

			 */
			SortedList sortedList = new SortedList();
			SortedList sortedList2 = new SortedList(5);
			//khởi tạo sortedlist và chỉ định capacity ban đầu là 5
			//Sao chép một sortedlist
			SortedList sortedList3 = new SortedList(sortedList2);
			/*
			 Định nghĩa một lớp PersonComparer có 1 interface IComparer
			 sau đó Override lại phương thức Compare
			 sử dụng lớp trên để truyền vào Contructor của SortList
			 */
			SortedList sortedList1 = new SortedList( new PersonComparer());
			sortedList1.Add( new Person("Kiet", 21), 10);
			sortedList1.Add(new Person("Tai", 20), 20 );
			sortedList1.Add(new Person("Tung", 23), 15);
			foreach (DictionaryEntry item in sortedList1)
			{
				Console.WriteLine(item.Key+"|"+item.Value);
			}
			
			Console.ReadLine();

		}
	}
}
