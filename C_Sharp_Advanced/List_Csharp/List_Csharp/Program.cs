using System;
using System.Collections;
using System.Collections.Generic;

namespace List_Csharp
{
	class Program
	{
		static void Main(string[] args)
		{
			#region khởi tạo list
			List<int> list = new List<int>();//khởi tạo list rỗng
			List<int> list1 = new List<int>(5);//khởi tạo list có 5 phần tử
			//sao chép toàn bộ phần tử list1 sang list2
			//Lưu ý sủ dụng  kiểu new List<int>(list) thì list2 sẽ tạo ra vùng nhớ riêng biệt
			//nếu sử dụng list2 =list1 thì cả hai đều dùng chung vùng nhớ
			List<int> list2 = new List<int>(list1);
			#endregion
			#region Sử dụng list
			//khởi tạo list kiêu dữ liệu string
			List<string> list4 = new List<string>();
			list4.Add("F");
			list4.Add("H");
			Console.WriteLine("Amount of list:" + list4.Count);
			Console.WriteLine("List string:");
			foreach (var item in list4)
			{
				Console.WriteLine(item);
			}

			//Chèn phần tử vào list
			list4.Insert(0, "T");

			Console.WriteLine("Amount of list after inserting :" + list4.Count);
			Console.WriteLine("List string after inserting:");
			foreach (var item in list4)
			{
				Console.WriteLine(item);
			}
			//Does checked item exist in list?
			bool check = list4.Contains("T");
			if (check)
			{
				Console.WriteLine("True");
			}
			else
				Console.WriteLine("False");
			#endregion
			Console.ReadLine();
		}
	}
}
