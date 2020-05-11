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
/*
 Given an array of integers, calculate the fractions of its elements that are positive, negative, and are zeros. Print the decimal value of each fraction on a new line.

Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to  are acceptable.

For example, given the array  there are  elements, two positive, two negative and one zero. Their ratios would be ,  and . It should be printed as

0.400000
0.400000
0.200000
Function Description

Complete the plusMinus function in the editor below. It should print out the ratio of positive, negative and zero items in the array, each on a separate line rounded to six decimals.

plusMinus has the following parameter(s):

arr: an array of integers
Input Format

The first line contains an integer, , denoting the size of the array. 
The second line contains  space-separated integers describing an array of numbers .

Constraints

 

Output Format

You must print the following  lines:

A decimal representing of the fraction of positive numbers in the array compared to its size.
A decimal representing of the fraction of negative numbers in the array compared to its size.
A decimal representing of the fraction of zeros in the array compared to its size.
Sample Input

6
-4 3 -9 0 4 1         
Sample Output

0.500000
0.333333
0.166667*/
class Solution
{

	// Complete the plusMinus function below.
	static void plusMinus(int n, int[] arr)
	{
		int posility = 0;
		int negality = 0;
		int zero = 0;
		for (var x = 0; x < n; x++)
		{
			if (arr[x] > 0)
			{
				posility++;
			}
			else
			if (arr[x] == 0)
			{
				zero++;
			}
			else
			if (arr[x] < 0)
			{
				negality++;
			}
		}
		Console.WriteLine("{0}\n{1}\n{2}", (float)posility / n, (float)negality / n, (float)zero / n);


	}

	static void Main(string[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());

		int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
		plusMinus(n, arr);
	}
}

