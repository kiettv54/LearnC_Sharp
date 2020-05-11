using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Given a square matrix, calculate the absolute difference between the sums of its diagonals.

For example, the square matrix  is shown below:

1 2 3
4 5 6
9 8 9  
The left-to-right diagonal = . The right to left diagonal = . Their absolute difference is .

Function description

Complete the  function in the editor below. It must return an integer representing the absolute diagonal difference.

diagonalDifference takes the following parameter:

arr: an array of integers .
Input Format

The first line contains a single integer, , the number of rows and columns in the matrix . 
Each of the next  lines describes a row, , and consists of  space-separated integers .

Constraints

Output Format

Print the absolute difference between the sums of the matrix's two diagonals as a single integer.

Sample Input

3
11 2 4
4 5 6
10 8 -12
Sample Output

15
Explanation

The primary diagonal is:

11
   5
     -12
Sum across the primary diagonal: 11 + 5 - 12 = 4

The secondary diagonal is:

     4
   5
10
Sum across the secondary diagonal: 4 + 5 + 10 = 19 
Difference: |4 - 19| = 15

Note: |x| is the absolute value of x*/
namespace Diagonal_Difference
{
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

	class Solution
	{

		// Complete the diagonalDifference function below.
		static int diagonalDifference(int n, int[][] arr)
		{
			int a = 0;
			int b = 0;
			for (var i = 0; i < n; i++)
			{
				var j = i;

				a += arr[i][j];

			}
			for (var i = 0; i < n; i++)
			{
				for (var j = 0; j < n; j++)
				{
					if ((i + j) == n - 1)
					{
						b += arr[i][j];
					}
				}
			}
			int s = a - b;
			return Math.Abs(s);

		}

		static void Main(string[] args)
		{
			TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

			int n = Convert.ToInt32(Console.ReadLine());

			int[][] arr = new int[n][];

			for (int i = 0; i < n; i++)
			{
				arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
			}

			int result = diagonalDifference(n, arr);

			textWriter.WriteLine(result);

			textWriter.Flush();
			textWriter.Close();
		}
	}

}
