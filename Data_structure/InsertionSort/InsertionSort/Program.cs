using System;

namespace InsertionSort
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Insertion Sort";

            var numbers = new[] { 9, 1, 5, 2, 4, 6, 3 };
            Sort(numbers);

            Console.ReadKey();
        }

        static void Swap<T>(T[] array, int i, int j)
        {
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        static void Print<T>(T[] array)
        {
            Console.WriteLine(string.Join("\t", array));
        }

        static void Sort<T>(T[] array) where T : IComparable
        {
            for (var i = 1; i < array.Length; i++)
            {
                var j = i;
                while (j > 0 && array[j].CompareTo(array[j - 1]) < 0)
                {
                    Swap(array, j, j - 1);
                    j--;
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"Step {i}:\t");
                Console.ResetColor();

                Print(array);
                Console.WriteLine();
            }
        }
    }
}