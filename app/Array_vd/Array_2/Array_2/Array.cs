using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_2
{
	class Array
	{
		int[,] arr;
		int n, m;
		public void Input()
		{
			Console.Write("Enter number Row:");
			n = int.Parse(Console.ReadLine());
			Console.Write("Enter number Column:");
			m = int.Parse(Console.ReadLine());
			arr = new int[n, m];
			for(int i=0;i<n;i++)
			{
				for(int j=0;j<m;j++)
				{
					Console.Write("arr[{0}][{1}]=", i + 1, j + 1);
					arr[i, j] = int.Parse(Console.ReadLine());
				}
				Console.WriteLine();
			}
		}
		public void Output()
		{
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					Console.Write(" "+arr[i,j]);
				}
				Console.WriteLine();
			}
		}
		public void Tinh()
		{
			Console.Write("Enter Row need tinh:");
			int dong = int.Parse(Console.ReadLine());
			int s = 0;
			for (int j = 0; j < m; j++) 
			{
				s += arr[dong-1, j];
			}
			Console.WriteLine("Tong dong {0} can tinh :{1}", dong, s);
		}
		public void Tinh2()
		{
			Console.Write("Enter Column need tinh:");
			int cot = int.Parse(Console.ReadLine());
			int s = 0;
			for (int i=0;i<n;i++)
			{
				s += arr[i,cot-1];
			}
			Console.WriteLine("Tong cot {0} can tinh :{1}", cot, s);
		}
		public int Sum()
		{
			int s = 0;
			for(int i=0;i<n;i++)
			{
				for(int j=0;j<m;j++)
				{
					s += arr[i, j];
				}
			}
			return s;
		}
	}
}
