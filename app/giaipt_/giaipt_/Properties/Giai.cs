using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace giaipt_
{
	class Giai
	{
		private float a;
		private float b;
		private float x;
		private float x1, x2;
		private float delta;
		private float c;
		public void nhap()
		{
			Console.WriteLine("Giai phuong trinh bac nhat ax+b=0:");
			Console.Write("nhap a:");
			float a = float.Parse(Console.ReadLine());
			Console.Write("nhap b:");
			float b = float.Parse(Console.ReadLine());
			if (a != 0)
			{
				x = -b / a;
				Console.WriteLine("phuong trinh co nghiem la x={0}", x.ToString());
				
			}
			else
				if (a == 0)
				{	if(b!=0)
						Console.WriteLine("phuong trinh vo nghiem!");
					else
					if (b == 0)
						Console.WriteLine("phuong trinh co vo so nghiem!");
				}
		}
		public void nhap2()
		{
			
			if (b != 0)
			{
				x = -c / b;
				Console.WriteLine("phuong trinh co nghiem la x={0}", x.ToString());

			}
			else
				if (b == 0)
			{
				if (c != 0)
					Console.WriteLine("phuong trinh vo nghiem!");
				else
				if (c == 0)
					Console.WriteLine("phuong trinh co vo so nghiem!");
			}
		}
		public void giaiptbac2()
		{
			Console.WriteLine("Giai phuong trinh bac hai ax2+bx+c=0:");
			Console.Write("nhap a:");
			float a = float.Parse(Console.ReadLine());
			Console.Write("nhap b:");
			float b = float.Parse(Console.ReadLine());
			Console.Write("nhap c:");
			float c =float.Parse(Console.ReadLine());
			if (a == 0) nhap2();
			else
			{
				delta = b * b - (4 * a * c);
				if (delta < 0) Console.WriteLine("phuong trinh vo nghiem!");
				else
					if(delta==0)
				{
					x1 =(float) -b / (2 * a);
					Console.WriteLine("phuong trinh co nghiem kep x1=x2={0}", x1.ToString());
				}
				else
					if(delta>0)
				{
					x1 = (float) (-b - Math.Sqrt(delta)) / (2 * a);
					x2 = (float) (-b + Math.Sqrt(delta)) / (2 * a);
					Console.Write("phuong trinh co hai nghiem x1={0}", x1.ToString());
					Console.Write(",x2={0}", x2.ToString());
				}

			}
			
		}


	}
}
