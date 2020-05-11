using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
	class SinhVien
	{
		string ten;
		float dtb;

		public void NhapSV()
		{
			Console.WriteLine("Nhap ho ten sinh vien");
			string ten = Console.ReadLine();
			Console.Write("Nhap diem trung binh: ");
			dtb = float.Parse(Console.ReadLine());
		}

		public void XuatSV()
		{
			Console.WriteLine("Ten sinh vien: {0}", ten);
			Console.WriteLine("Diem trung binh: {0}", dtb);
			Console.WriteLine("\n--------------------------");
		}

	}

	class Mang // an array of SinhVien objects with simple input/output methods
	{
		SinhVien[] a;
		int n;

		public Mang() // plain constructor
		{ a = new SinhVien[100]; }

		public void NhapMang()
		{
			Console.WriteLine("Nhap so sv");
			n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine("Nhap chi tiet sinh vien thu {0}", i + 1);
				a[i] = new SinhVien();
				a[i].NhapSV();
			}
		}

		public void XuatMang()
		{
			for (int i = 0; i < n; i++) a[i].XuatSV();
		}
	}
}
