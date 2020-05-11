using System;
using System.Collections;

namespace Queue_Csharp
{
	class Program
	{
		static void Main(string[] args)
		{
			Queue queue = new Queue();
			//thêm phần tử thông quaenqueue
			queue.Enqueue("H");
			queue.Enqueue("F");
			queue.Enqueue("E");
			//phương thức count
			Console.WriteLine("So phan tu hien tai trong Queue:" + queue.Count);
			//Sử dụng Peek để xem giá trị mà không cần phải xóa khoi queue
			Console.WriteLine("Phan tu dau tien cua Queue:" + queue.Peek());
			// sử dụng Dequeue để lấy và xóa giá trị khỏi Queue
			Console.WriteLine("Poping...........");
			int length = queue.Count;
			for (int i = 0; i < length; i++)
			{
				Console.WriteLine(queue.Dequeue());
			}
			//Check lại số phần tử sau khi Dequeue
			Console.WriteLine("So phan tu hien tai sau khi Dequeue trong Queue:" + queue.Count);
			Console.ReadLine();

		}
	}
}
