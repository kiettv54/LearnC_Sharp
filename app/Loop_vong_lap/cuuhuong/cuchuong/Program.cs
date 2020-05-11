using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuchuong
{
	class Program
	{
		static void Main(string[] args)
		{
			nine a = new nine();
			int k;
			Console.Write("1.In bang cuu chuong.\t2.In bang cuu chuong bat ky\nBan chon:");
			k = int.Parse(Console.ReadLine());
			if(k==1)
			{
				Console.WriteLine("---Danh sach bang cuu chuong---");
				a.cuuchuong();
			}
			else
				if(k==2)
			{
				a.hai();
				a.donchuong();

			}
			Console.ReadLine();
		}
	}
}
