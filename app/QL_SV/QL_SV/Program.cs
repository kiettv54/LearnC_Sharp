using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_SV
{
	class Program
	{
		static void Main(string[] args)
		{
			SINHVIEN a = new SINHVIEN();
			a.Input();
			Console.WriteLine("Information of Student:");
			a.Output();
			Console.ReadKey();
		}
	}
}
