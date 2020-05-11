using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vitri
{
	class Array
	{
		int n;
		int[] a;
		int x;
		public void Input()
		{
			Console.Write("Enter N:");
			n = int.Parse(Console.ReadLine());
			a = new int[n];
			for(int i=0;i<n;i++)
			{
				Console.Write("a[{0}]=", i+1 );
				a[i] = int.Parse(Console.ReadLine());
			}
		}
		public void Output()
		{
			for(int i=0;i<n;i++)
			{
				Console.Write(" "+a[i]);
			}
		}
		//nhap vi tri mang roi xuat gia tri cua mang
		public void SearchX()
		{
			Console.Write("Enter Location of X:");
			x = int.Parse(Console.ReadLine());
			int dem = 0;
			for(int i=0;i<n;i++)
			{
				if((x-1)==i)
				{
					Console.WriteLine("Location of X in Array List:"+a[i]);
					dem++;
				}
			}
			if (dem == 0)
				Console.WriteLine("Error");
			
		}
		public void CopyArray()
		{
			int[] b = new int[n];
			for(int i=0;i<n;i++)
			{
				b[i] = a[i];
			}
			for(int i=0;i<n;i++)
			{
				Console.Write(" " + b[i]);
			}
		}
	}
}
