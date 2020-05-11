using System;
using System.Collections;

namespace Stack_Csharp
{
	class Program
	{
		static void Main(string[] args)
		{
			#region khai báo stack
			Stack stack = new Stack();//khởi tạo tách rỗng
			Stack stack1 = new Stack(5);//	khởi tạo stack chứa 5 phần tử ban đầu
										//khởi tạo mảng bất kỳ
			ArrayList arrayList = new ArrayList(5) { 5, 9, 10, 3, 5 };
			Stack stack2 = new Stack(arrayList);
			#endregion
			#region ứng dụng stack
			Stack stack3 = new Stack();
			stack3.Push("E");
			stack3.Push("F");
			stack3.Push("H");
			//sử dụng các phương thúc của stack
			Console.WriteLine("So phan tu hien co trong stack:" + stack3.Count);
			//Sử dụng peek để xem giá trị  mà không lấy giá trị ra khỏi stack
			Console.WriteLine("phan tu dau cua stack:" + stack3.Peek());

			///thực hiện xóa phần tử ra khỏi stack
			int length = stack3.Count;
			Console.WriteLine("Poping............");
			for (int i = 0; i < length; i++)
			{
				Console.WriteLine(" " + stack3.Pop());
			}
			Console.WriteLine();
			Console.WriteLine("So phan tu hien co trong stack:" + stack3.Count);
			#endregion
			Console.ReadLine();
		}
	}
}
