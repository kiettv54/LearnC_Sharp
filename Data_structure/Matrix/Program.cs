using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int m=3,n=4;
            int[,] arr;
            int start = 0;
            Process process = new Process();
            process.Input(out m,out n);
            int x1 = 0, x2 = n-1;
            int y1 = 0, y2 = m-1;
            arr = new int[m,n];
            process.StopRight(ref arr , x1, x2, y1, y2,ref start );
            process.Output(arr,m,n);
            Console.ReadLine();
        }
    }
}
