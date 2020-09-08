using System;

namespace LearnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1,2,3,4,5,6};
            foreach (var item in array)
            {
                Console.Write(item+"\t");
            }
            Console.ReadLine();
        }
    }
}
