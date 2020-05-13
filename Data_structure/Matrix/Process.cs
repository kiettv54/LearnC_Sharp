using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Matrix
{
    public class Process
    {
        private int[,] arr;
        private int m,n;
        public Process(){}
        public Process( int m, int n)
        {
            this.m = m;
            this.n = n;
            arr = new int[m,n];
        }
        public void Input(out int m,out int n)
        {
            Console.WriteLine("Input m:");
            m =int.Parse(Console.ReadLine());
            Console.WriteLine("Input n:");
            n =int.Parse(Console.ReadLine());
            
        }
        public void  StopRight(ref int[,] a ,int x1,int x2,int y1,int y2,ref int start ){
            for (int i = x1; i <= x2; i++)
            {
                a[y1,i] = start++;
            }
            for (int i = y1+1; i <= y2; i++)
                {
                    a[i,x2]=start++;
                }
            if(x1<x2 && y1<y2)
            {
                y1++;
                x2--;
                BottomLeft(ref a,x1,x2,y1,y2,ref start);

            }
        }

        private void BottomLeft(ref int[,] a, int x1, int x2, int y1, int y2, ref int start)
        {
            for (int i = x2; i >= x1; i--){
                a[y2,i]=start++;
            }
            for (int i = y2-1; i >= y1; i--){
                a[i,x1]=start++;
            }
            if(x1<x2 && y1<y2)
            {
                x1++;
                y2--;
                StopRight(ref a,x1,x2,y1,y2,ref start);

            }

        }
        public void Output(int [,] a,int m,int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                   if(a[i,j]<10)
                   {
                       Console.Write("0{0} ",a[i,j]);
                   }
                   else
                   {
                        Console.Write(a[i,j]+" ");
                   }
                }
                Console.WriteLine();
            }
        }
    }
}