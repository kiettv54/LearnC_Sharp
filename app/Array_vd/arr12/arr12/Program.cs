using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arr12
{
	class Program
	{
		static void Input(int n,int[] a)
		{
			for(int i=0;i<n;i++)
			{
				
					Console.Write("a[{0}]=", i + 1);
					a[i] = int.Parse(Console.ReadLine());
			
			}
		}
		static void Output(int n, int[] a)
		{
			for (int i = 0; i < n; i++)
			{
				
				
					Console.Write(a[i] + " ");
				
			}
		}
		static void Main(string[] args)
		{
			 
			int n;
			Console.Write("Enter N:");
			n = int.Parse(Console.ReadLine());
			int[] a = new int[n];
			Input(n, a);
			Console.WriteLine("Array List:");
			Output(n, a);
			Console.ReadKey();
		}
	}
}
