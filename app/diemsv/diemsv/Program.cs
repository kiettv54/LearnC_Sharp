using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diemsv
{
	class Program
	{
		static void Main(string[] args)
		{
			Array a = new Array();
			a.InputArray();
			Console.WriteLine("---Danh sach sinh vien----");
			a.OutPut();
			Console.WriteLine("\n--danh sach hoc sinh co tong tren 15----");
			a.Diemdau();
			/*List<SinhVien> sinhVienList = new List<SinhVien>();
			sinhVienList.Sort(new SinhVienTongComparer());
			foreach(var item in sinhVienList)
			{
				item.xuat();
			}*/
			Console.ReadKey();
			

		}
	}

}
