using System;
using System.Collections;
namespace Generic_Csharp
{
	class Program
	{
		public static void Swap(ref int a,ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		}
		public static void Swap<T>(ref T a,ref T b)
		{
			T temp = a;
			a = b;
			b = temp;
		}	
		
		static void Main(string[] args)
		{
			int a = 5, b = 7;
			double c = 3, d = 4;
			///cú phap generic :Tên hàm <Ký hiệu(ví dụ t,k,d,h)>(ref ký hiệu <tên biến>)
			Swap<int>(ref a,ref b);
			Swap<double>(ref c,ref d);
			#region Generic trong class
			MyGeneric<int> MyG= new MyGeneric<int>(5);
			MyG.setItemValue(0, 10);
			MyG.setItemValue(1, 11);

			#endregion
			/*
			 Một số collection phổ biến
			 List<T>,Dictionary<TKey,TValue>,SortedDictonary<TKey,TValue>,Stack<T>,Queue<T>
			 
			 */
			Console.ReadLine();
		}
	}
}
