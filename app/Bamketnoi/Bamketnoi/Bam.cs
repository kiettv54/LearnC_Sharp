using System;
using System.Collections.Generic;
using System.Text;


namespace Bamketnoi
{
   
    class Bam
    {
        private int n,m;
        private int[,] a;
       
        public void Input()
        {
            test:
                try
                {
                    Console.Write("Enter row:");
                    n = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.WriteLine("error datatypes ");
                    goto test;
                }
            test1:
                try
                {
                    Console.Write("Enter column:");
                    m = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.WriteLine("error datatypes ");
                    goto test1;
                }
           
            a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j= 0; j < m; j++)
                {
                    test2:
                    try
                    {
                        Console.Write("Enter a[{0}][{1}]=", i, j);
                        a[i, j] = int.Parse(Console.ReadLine());
                    }
                    catch 
                    {


                        Console.WriteLine("error datatypes ");
                        goto test2;
                    }
                }
                Console.WriteLine();
            }
        }
        public void Output()
        {
           
            foreach (int item in a)
            {
                Console.Write(item + " ");
            }
        }
    }
}
