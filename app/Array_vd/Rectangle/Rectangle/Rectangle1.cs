using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
	class Rectangle1
	{
		int l,w;
		public void Input()
		{
			Console.Write("Enter Length:");
			l = int.Parse(Console.ReadLine());
			Console.Write("Enter Width:");
			w = int.Parse(Console.ReadLine());
		}
		public void Output()
		{
			/*Cach 1
			 * for(int i=1;i<=l;i++)
			{
				{
					for(int j=1;j<=w;j++)
					{
						Console.Write('*');
					}
					Console.WriteLine();
				}
				
			}*/
			//cach 2
			for(int i=1;i<=l;i++)
			{
				for(int j=1;j<=w;j++)
				{
					if (i == 1 || i == l || j == 1||j==w)
					{
						Console.Write('*');
					}
					else
						Console.Write(' ');
				}
				Console.WriteLine();
			}
		}
			
	}
	class Tamgiac
	{
		int hight;
		public void Input1()
		{
			Console.Write("Enter Hight of Triangle: ");
			hight = int.Parse(Console.ReadLine());
		}
		public void Output1()
		{
			//Print Hight of Triangle in c#
			for (int i=0;i<hight;i++)
			{
				for (int k = hight - 1; k > i; k--)
				{
					Console.Write(' ');
				}

					//print width of Triangle
				for(int j=1;j<=i*2+1;j++)
				{
					Console.Write('*');
				}
				Console.WriteLine();
			}
			
		}
	}
}
