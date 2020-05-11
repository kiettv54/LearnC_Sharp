using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBai1.Properties
{
	class Animal
	{

		public double Weight;
		public double Height;

		public void Info()
		{

			/*
                Các phương thức bên trong lớp có thể gọi đến các thành phần khác (bao gồm thuộc tính và phương thức) trong lớp đó.
                Giá trị của các thuộc tính này có thể được khởi tạo đâu đó trong lớp hoặc từ bên ngoài truyền vào.
             */

			Console.WriteLine(" Height: " + Height + " Weight: " + Weight);

		}
	}

}
