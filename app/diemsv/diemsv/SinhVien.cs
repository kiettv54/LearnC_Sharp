using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diemsv
{
	class SinhVien
	{
		private string Hoten;
		string lop;
		 float toan, ly, hoa;
		
		public void nhap()
		{
			Console.Write("nhap ho ten sinh vien:");
			 Hoten = Console.ReadLine();
			Console.Write("nhap lop:");
				lop = Console.ReadLine();
			do
			{
				Console.Write("nhap diem mon toan:");
				toan = float.Parse(Console.ReadLine());
				if (toan < 0 || toan > 10)
					Console.WriteLine("Diem toan khong hop le!");

			} while (toan < 0 || toan > 10);
			do
			{
				Console.Write("nhap diem mon hoa:");
				hoa = float.Parse(Console.ReadLine());
				if (hoa < 0 || hoa > 10)
					Console.WriteLine("Diem hoa khong hop le!");
			} while (hoa < 0 || hoa > 10);
			do
			{
				Console.Write("nhap diem mon ly:");
				ly = float.Parse(Console.ReadLine());
				if (ly < 0 || ly > 10)
					Console.WriteLine("Diem ly khong hop le!");
			} while (ly < 0 | ly > 10);
			
		}
	
		public void xuat()
		{
			Console.Write("\nHo ten:{0}", Hoten);
			Console.Write("\tLop:{0}", lop);
			Console.Write("\tToan:{0}\tHoa:{1}\tLy:{2}\tTong:{3}",toan,hoa,ly,tong());
		}
		public float tong()
		{
			return toan + ly + hoa;
		}

	}
	class Array
	{
		int n;
		SinhVien[] a;
		public Array()
		{
			a = new SinhVien[0];
		}
		public void InputArray()
		{
			Console.Write("nhap so luong sinh vien:");
			n = int.Parse(Console.ReadLine());
			a = new SinhVien[n];
			for(int i=0;i<n;i++)
			{
				Console.WriteLine("nhap sinh vien thu {0}:", i + 1);
				a[i] = new SinhVien();
				a[i].nhap();
			}
		}
		public void OutPut()
		{
			for(int i=0;i<n;i++)
			{
				a[i].xuat();
			}
		}
		public void Diemdau()
		{
			for (int i = 0; i < n; i++)
			{
				if (a[i].tong() >= 15)
					a[i].xuat();
			}
		}

	}
	/*
	public class SinhVienTongComparer : IComparer<SinhVien>
	{
		public int Compare(SinhVien x, SinhVien y)
		{
			return x.tong.CompareTo(y.tong);
		}

	}*/



}
