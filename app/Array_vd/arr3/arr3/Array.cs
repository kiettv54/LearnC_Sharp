using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arr3
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
				Console.Write("a[{0}]=", i + 1);
				a[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("You Continue to choose!");
		}
		public void Output()
		{
			for(int i=0;i<n;i++)
			{
				Console.Write(a[i] + " ");
			}
			Console.WriteLine("You Continue to choose!");
		}
		
		public int search_max()
		{
			int max = a[0];
			for (int i = 1; i < n; i++)
			{
				if (a[i] > max)
				{
					max = a[i];
				}
			}
			Console.WriteLine("You Continue to choose!");
			return max;
		}
		public void SelectionSort()
		{
			for(int i=0;i<n;i++)
			{
				int min = i;
				for(int j=i+1;j<n;j++)
				{
					if(a[j]>a[min])
					{
						min = j;
					}
				}
				if(min!=i)
				{
					int tam = a[i];
					a[i] = a[min];
					a[min] = tam;
				}
			}
			Console.WriteLine("You Continue to choose!");
		}
		public int SearchNumber()
		{
			for(int i=0;i<n;i++)
				if(a[i]==x)
				{
					return i;
				}
			return -1;
		}
		public void Delete()
		{
			Console.Write("Enter X Want to Delete:");
			x = int.Parse(Console.ReadLine());
			int v = SearchNumber();
			if (v == -1)
				Console.WriteLine("Error");
			else
			{
				for (int i = v; i <= n -2; i++)
				{
					a[i] = a[i + 1];
					n--;
				}
			}
			Console.WriteLine("You Continue to choose!");

		}
	}
	
}
