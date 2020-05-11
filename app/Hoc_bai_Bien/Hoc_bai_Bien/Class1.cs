using System;
using System.Collections.Generic;
using System.Text;

namespace Hoc_bai_Bien
{
    class Class1
    {
        public string[] arr;
        public int n;
        public void input()
        {
            Console.WriteLine("Enter n:");
            n = int.Parse(Console.ReadLine());
            arr = new string[n];
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter string {0}:", i + 1);
                arr[i] = Console.ReadLine();
            }
        }
        public void output()
        {
            for (int i = 0; i < n; i++)

            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
