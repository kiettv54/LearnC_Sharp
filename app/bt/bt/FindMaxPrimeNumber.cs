using System;
using System.Collections.Generic;
using System.Text;

namespace bt
{
	class FindMaxPrimeNumber
	{
		private int a, b, c, d;
		public FindMaxPrimeNumber() { }
		public FindMaxPrimeNumber(int a,int b ,int c, int d)
		{

			this.A = a;
			this.B = b;
			this.C = c;
			this.D = d;
		}
		public void Input()
		{
			Console.WriteLine("Enter a:");
			this.A = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter b:");
			this.B = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter c:");
			this.C = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter d:");
			this.D = int.Parse(Console.ReadLine());
		}
		public int MaxPrime()
		{
			
			int max = A;
			if (max < B)
				max = B;
			if (max < C)
				max = C;
			if (max < D)
				max = D;
			return max;


		}
		public int A { get => a; set => a = value; }
		public int B { get => b; set => b = value; }
		public int C { get => c; set => c = value; }
		public int D { get => d; set => d = value; }
		
	}
}
