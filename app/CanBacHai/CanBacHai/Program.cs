using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanBacHai.Properties;
namespace CanBacHai
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Tính căn bậc hai";
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("---chuong trinh tinh can bac hai---");
			Console.ResetColor();
			Tinh db = new Tinh();
			db.Input();
			Console.WriteLine("Ket qua:" + db.Output());
			Console.ReadLine();
		}
	}
}
