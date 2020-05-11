using System;

namespace Hoc_bai_Bien
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Class1 clss = new Class1();
            Console.Write("Enter N:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("number is " + n);
            test(ref n);
            Console.WriteLine("number is " + n);
            clss.input();
            Console.WriteLine("---------------String List-------------");
            clss.output();
            Console.ReadLine();
            
        }
        static void test(ref int value)
        {
            value++;
        }
    }
}
