using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaipt_
{
	class Program
	{
		static void Main(string[] args)
		{
			Giai s = new Giai();
			float n;
			Console.Write("1.giai phuong trinh bac nhat!\n2.Giai phuong trinh bac hai!\nBan chon 1 hay 2:");
			n = float.Parse(Console.ReadLine());
			if(n==1)
					s.nhap();
			else if(n==2)
					s.giaiptbac2();
	
			Console.ReadKey();
		}
	}
}
