using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace AppleandOrange
{
	class Program
    {
        /// <summary>
        /// data test 
        /// 7 11
        //5 15
        //3 2
        //-2 2 1
        //5 -6
        /// </summary>
        /// <param name="s">7</param>
        /// <param name="t">11</param>
        /// <param name="a">5</param>
        /// <param name="b">15</param>
        /// <param name="apples">-2 2 1</param>
        /// <param name="oranges">5 -6</param>
        // Complete the countApplesAndOranges function below.
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            ArrayList arraya = new ArrayList(apples);
            ArrayList arrayo = new ArrayList(oranges);
            int countapples = 0;
            int countoranges = 0;
            foreach (int item in arraya)
            {
                int temp = a + Convert.ToInt32(item);
                if (s <= temp && temp <= t)
                {
                    countapples += 1;
                }
            }
            foreach (var item in arrayo)
            {
                int temp = b + Convert.ToInt32(item);
                if (s <= temp && temp <= t)
                {
                    countoranges += 1;
                }
            }
            Console.WriteLine(countapples);
            Console.WriteLine(countoranges);

        }

        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
            ;

            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
            ;
            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }
}
