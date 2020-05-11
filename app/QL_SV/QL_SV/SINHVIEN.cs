using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QL_SV
{
	class SINHVIEN
	{
		public int MASV;
		public string NameSV;
		public DateTime Birthday;
		public string Phone;
		public string Native_village;
		public void Input()
		{
			Console.Write("Enter MSSV:");
			MASV = int.Parse(Console.ReadLine());
			Console.Write("Enter Student's Full-Name:");
			NameSV = Console.ReadLine();
			Console.Write("Enter Birth of Student:");
            Birthday = DateTime.Parse(Console.ReadLine());
			Console.Write("Enter Number Phone of Student:");
			Phone = Console.ReadLine();
			Console.Write("Enter Native village of Student:");
			Native_village = Console.ReadLine();
		}
		public void Output()
		{
			Console.WriteLine("MSSV:" + MASV);
			Console.WriteLine("FULL-NAME:" + NameSV);
			Console.WriteLine("Birth :"+Birthday);
			Console.WriteLine("Phone:" + Phone);
			Console.WriteLine("Native Village:" + Native_village);

		}
	}
}
