using BBai1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBai1
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
               Khởi tạo 2 đối tượng thuộc lớp Animal là:
                + Dog có chiều cao 50cm và cân nặng 2kg.
                + Cat có chiều cao 30cm và cân nặng 1kg.
*/
			Animal Dog = new Animal();
			Dog.Weight = 2; // gán giá trị cho các thuộc tính của đối tượng
			Dog.Height = 50;


			Animal Cat = new Animal();
			Cat.Weight = 1;
			Cat.Height = 30;


			Dog.Info(); // gọi phương thức của đối tượng
			Cat.Info();
			Console.ReadLine();
		}
	}
}
