using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuchuong
{
	class nine
	{
		
		int x;
		int n, y;
		
		public void cuuchuong()
		{
			 n = 1;
			
			do
			{
				 y = 1;
				do
				{
					
					Console.WriteLine("{0} x {1}={2}",n,y,n*y);
					y++;
				} while (y <= 10);
				Console.WriteLine();
				
				n++;
			} while (n <= 9);

		}
		public void hai()
		{
			Console.Write("Enter a number :");
			x = int.Parse(Console.ReadLine());

		}
		public void donchuong()
		{
			 y = 1;
			Console.WriteLine("Bang cuu chuong cua" + x + ":");
			do
			{
				
				Console.WriteLine("{0} x {1}={2}" ,x,y, x * y);
				y++;
			} while (y <= 10);
		}


	}
}
