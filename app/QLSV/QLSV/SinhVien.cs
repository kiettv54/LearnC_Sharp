using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
	class SinhVien
	{
		int MaSv;
		string TenSV;
		int Old;
		string Lop;
		public void Input()
		{
			Console.Write("Input MSSV:");
			MaSv = int.Parse(Console.ReadLine());
			Console.Write("Input Full Name:");
			TenSV = Chuanhoa(Console.ReadLine());
			Console.Write("Old:");
			Old = int.Parse(Console.ReadLine());
			Console.Write("Class:");
			Lop = Console.ReadLine();
		}
		string Chuanhoa(string chuoi)
		{
			chuoi = chuoi.Trim();
			string kq = "";
			do
			{
				chuoi = chuoi.Replace("  ", " ");
			} while (chuoi.IndexOf("  ") != -1);
			string[] arr = chuoi.Split(' ');
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = arr[i].Substring(0, 1).ToUpper() + arr[i].Substring(1).ToLower()+" ";
				kq += arr[i];
			}
			return kq;
		}
		public void Output()
		{
			Console.WriteLine("MSSV:{0}", MaSv);
			Console.WriteLine("Full-Name:{0}", TenSV);
			Console.WriteLine("Old:{0}", Old);
			Console.WriteLine("Class:{0}", Lop);
		}
	}
	class Array:SinhVien
	{
		int n;
		SinhVien[] a;
		public Array()
		{
			a = new SinhVien[0];
		}
		public void Input1()
		{
			Console.Write("Enter N:");
			n = int.Parse(Console.ReadLine());
			a = new SinhVien[n];
			for(int i=0;i<n;i++)
			{
				Console.WriteLine("Enter Student {0}:", i + 1);
				a[i] = new SinhVien();
				a[i].Input();
			}
		}
		public void Output1()
		{
			for(int i=0;i<n;i++)
			{
				a[i].Output();
				Console.Write("------------------");
			}
		}
	
	}
}
		