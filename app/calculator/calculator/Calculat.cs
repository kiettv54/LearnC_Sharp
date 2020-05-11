using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
	class Calculat
	{
		int a, b;
		public void Input()
		{
			Console.Write("Enter number a:");
			a = int.Parse(Console.ReadLine());
			Console.Write("Enter number b:");
			b = int.Parse(Console.ReadLine());
		}
		public void Output()
		{
			//khai bao ket qua
			double kq = 0 ;

			//choose oparator
		
		
			Console.WriteLine("Moi ban chon phep tinh:");
			Console.WriteLine("1.phep cong, 2.phep tru, 3.phep nhan, 4 phep chia, 5.Thoat\n Ban chon:");
			int choose = int.Parse(Console.ReadLine());

			switch (choose)
			{
				case 1:
					kq = a + b;
					break;
				case 2:
					kq = a - b;
					break;
				case 3:
					kq = a * b;
					break;
				case 4:
						kq = a / Convert.ToDouble(b);
						break;

				case 5:
					break;
			
			}
			
			if(choose !=4)
			{
				Console.WriteLine("Ket qua:" + kq);
			}
			else
			{
				Console.WriteLine("Ket qua:" + kq);
				KetquaChia2();
				
			}

		}
		public void KetquaChia2()
		{
			if (a != 0 && b != 0)
			{
				
				a = a / (UCLN());
				b = b / (UCLN());


				Console.Write("Hoac ket qua:" + a);
				Console.Write("/" + b);

			}
		}
		public int UCLN()
		{
			if(a!=0 && b!=0)
			{
				while (a != b)
				{
					if (a > b)
					{
						a = a - b;
					}
					else
					{
						b = b - a;
					}
				}
				return a; 
			}
			return 0;
			
		}
	}
}
