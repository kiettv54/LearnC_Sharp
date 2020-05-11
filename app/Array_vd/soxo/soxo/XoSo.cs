using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soxo
{
	class XoSo
	{
		int de;
		int tien;
	
		public void Input()
		{
			
			//choi de
			Console.Write("Moi ban nhap con de ban muon choi:");
			int de = int.Parse(Console.ReadLine());
			Console.Write("Moi nhap so tien muon choi:");
			int tien = int.Parse(Console.ReadLine());
			
		}
		public void Output()
		{
			//quay giai
			Random r = new Random();
			string db = r.Next(0, 99999).ToString("00000");
			string nhat = r.Next(0, 99999).ToString("00000");
			string nhi_1 = r.Next(0, 99999).ToString("00000");
			string nhi_2 = r.Next(0, 99999).ToString("00000");
			//int ket qua
			Console.WriteLine("Giai dac biet:" + db);
			Console.WriteLine("Giai nhat:" + nhat);
			Console.WriteLine("Giai nhi:{0} or {1}" , nhi_1,nhi_2);
			//so sanh ketqua
			int kq = int.Parse(db.Substring(3, 2));
			if (kq == de)
			{
				tien *= 70;
				Console.WriteLine("Ban trung {0} lien lac voi XS_DE de nhan giai!", tien);
			}
			else
			{
				Console.WriteLine("Ban thua roi!");
			}
		}




	}
}
