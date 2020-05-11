using System;
using System.Collections;

namespace Colection
{
	class Program
	{
        static void miniMaxSum(int[] arr)
        {
            ArrayList arrayList = new ArrayList();

            int k = arr.Length - 1;
            for (int i = 0; i <= k; i++)
            {
                double sum = 0;
                for (int j = 0; j <= k; j++)
                {
                    if (i != j)
                    {
                        sum += arr[j];
                    }
                }
                Console.WriteLine(sum);
                arrayList.Add(sum);
            }
            arrayList.Sort();

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }


        }

        static void Main(string[] args)
        {
            int[] arr = new int[5] {396285104,573261094,759641832,819230764,364801279 }; //Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            miniMaxSum(arr);
            Console.ReadLine();
        }
    }
}
