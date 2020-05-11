using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_SNT
{
	class TimNT
	{
		int n,crt, head, last, i;
		public void Input()
		{
			Console.Write("Enter a Head:");
			head = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter a last:");
			last = Convert.ToInt32(Console.ReadLine());
		}
		public void Search()
		{
			for(n=head;n<=last; n++)
			{
				crt = 0;
				for(i=2;i<=n/2;i++)
				{
					{
						if(n % i== 0)
						{
							crt++;
							break;
						}
					}
				}
				if(crt==0&& n!=1)
				{
					Console.Write(n + " ");
				}
			}
		}
	}
}
