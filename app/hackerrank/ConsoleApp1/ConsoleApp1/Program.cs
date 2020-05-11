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
/// <summary>
/// Calculate and print the sum of the elements in an array, keeping in mind that some of those integers may be quite large.

/*Function Description

Complete the aVeryBigSum function in the editor below.It must return the sum of all array elements.

aVeryBigSum has the following parameter(s):


ar: an array of integers .
Input Format


The first line of the input consists of an integer . 
The next line contains  space-separated integers contained in the array.


Output Format


Print the integer sum of the elements in the array.
Sample Input

5
1000000001 1000000002 1000000003 1000000004 1000000005
Output

5000000015*/
/// </summary>
class Solution
{

	// Complete the aVeryBigSum function below.
	static long aVeryBigSum(int arCount, long[] ar)
	{
		long s = 0;
		for (var i = 0; i < arCount; i++)
		{
			s += ar[i];
		}
		return s;


	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int arCount = Convert.ToInt32(Console.ReadLine());

		long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
		;
		long result = aVeryBigSum(arCount, ar);

		textWriter.WriteLine(result);

		textWriter.Flush();
		textWriter.Close();
	}
}

