using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatMagic
{
	class Magic
	{
		string User;
		string dap_an;
		string goi_y;
		public void Input()
		{
			Console.Write("Enter Player:");
			User = Console.ReadLine();
			Console.Write("Enter Ask:");
			dap_an = Console.ReadLine();
			Console.Write("Enter Idea:");
			goi_y = Console.ReadLine();

		}
		public void Output()
		{
			char[] dap_an_1 = dap_an.ToCharArray();
			char[] dap_an_2 = new char[dap_an.Length];
			Console.WriteLine(goi_y);
			//print ask print to the screen is *
			//gan mang la cac ki tu(character la cac dau *
			for (int i=0;i<dap_an.Length;i++)
			{
				dap_an_2[i] = '*';
			}
			for(int i=0;i<dap_an.Length;i++)
			{
				Console.Write(" " + dap_an_2[i]);
			}
			// print to the screen
			for(int i=0;i<dap_an.Length;i++)
			{
				Console.Write(" " + dap_an_2[i]);
			}
			Console.WriteLine();
			int n = 0;
				do
			{
				Console.WriteLine("Invite players to enter answers:");
				string play = Console.ReadLine();
				//is checking answer  right or wrong?
				int dem = 0;
				for (int i = 0; i < dap_an.Length; i++)
				{
					if (string.Compare(dap_an_1[i].ToString(), play, true) == 0)
					{
						dem++;
						dap_an_2[i] = dap_an_1[i];//if true,array 2=array1 is location but player guess right
					}
				}
				//print to the creen is answer
				Console.WriteLine("Have {0} char {0} in String!!!", dem, play);
				//print to creen array 2 after answering right
				for (int i = 0; i < dap_an.Length; i++)
				{
					Console.Write(" " + dap_an_2[i]);
				}
				Console.WriteLine();

			} while (n == 0);

		}

	}
}
