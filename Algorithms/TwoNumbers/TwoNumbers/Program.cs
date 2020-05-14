using System;
using System.Collections;
using System.Collections.Generic;

namespace TwoNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int[] { 1, 4, 6, 8, 9, 4, 10 };
			int target = 15;
			Tuple<int,int> tuble = TwoNumber(arr, target);
			if (tuble == null)
				Console.WriteLine("Don't have two numbers in array!");
			else
				Console.WriteLine(tuble.Item1 + " " + tuble.Item2);
			Console.ReadLine();

		}
		public static Tuple<int,int> TwoNumber(int[] arr,int target)
		{
			List<int> list = new List<int>(arr);
			HashSet<int> hs = new HashSet<int>();
			for (int i = 0; i < arr.Length; i++)
			{
				var temp = target - arr[i];
				if(hs.Contains(temp))
				{
					return Tuple.Create(list.IndexOf(temp), i);
				}
				hs.Add(list[i]);
			}
			return null;
		}
	}
}
