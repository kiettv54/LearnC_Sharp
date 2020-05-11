using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sohoanhao
{
	class Tinh
	{
		int n;
		int[] a;
		public void Input()
		{
			Console.Write("Enter N:");
			n = int.Parse(Console.ReadLine());
			a = new int[n];
			
			for(int i=0;i<n;i++)
			{
				Console.Write("Enter a[" + (i + 1)+"]=");
				a[i] = int.Parse(Console.ReadLine());
			}
		}
		public void Tinhs()
		{
			int dem = 0;
			int k;
			for(int i=0;i<n;i++)
			{
				k = a[i];
				int s = 0;
				for (int j=1;j<k;j++)
				{
					if (k % j == 0)
						s += j;
				}
				if(s==k)
				{
					Console.Write(" " + k);
					dem++;
				}
			}
			if (dem == 0)
				Console.WriteLine("Error .Because It don't have!");
		}
	}
}
