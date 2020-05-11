using System;
using System.Collections;

namespace BitArray_Csharp
{
	class Program
	{
		public static void PrintBits(BitArray bitArray,int width)
		{
			int i = width;
			foreach (bool item in bitArray)
			{
				if(i<1)
				{
					i = width;
					Console.WriteLine();
				}
				i--;
				Console.Write(item.GetHashCode());//in ra 0 1 thay vì true false
				
			}
			Console.WriteLine();
		}
		static void Main(string[] args)
		{
			#region Khởi tạo bitarray
			//không thể khở tạo bitarray rỗng
			//khởi tạo bitarray có 10 phần tử,mỗi phần tử có giá trị mặc định là false
			BitArray bitArray = new BitArray(10);
			//khởi tạo bitarray có 10 phần tử,mỗi phần tử có giá trị là true
			BitArray bitArray2 = new BitArray(10,true);
			//khởi tạo bitarray từ array bool có sẵn
			bool[] bools = new bool[4] { true, false, true, false };
			BitArray bitArray3 = new BitArray(bools);
			//Khởi tạo bitarray từ byte array
			byte[] bytes = new byte[5] { 1, 2, 3, 4, 5 };
			BitArray bitArray4 = new BitArray(bytes);
			Console.WriteLine("So bit của bitarray4:" + bitArray4.Length);
			PrintBits(bitArray4, 8);
			#endregion
			#region  Sử dụng bitarray
			#endregion
			Console.ReadLine();
		}
	}
}
