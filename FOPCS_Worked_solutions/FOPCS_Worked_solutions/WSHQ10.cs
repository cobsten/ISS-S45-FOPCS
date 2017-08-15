using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class WSHQ10
    {
        static void Main()
        {
            int[,] a ={
                {2,3 },
                {3,4 },
                {3,3 },
                {4,3 }
            };
            int[,]b={
                { 1,3,3},
                { 1,3,5}
            };
            int[,] answer = new int[a.GetLength(0), b.GetLength(1)];
               answer = MatrixMultiply(a, b);
            for(int i=0; i < answer.GetLength(0); i++)
            {
                for(int j=0; j < answer.GetLength(1); j++)
                {
                    Console.Write("{0}\t", answer[i, j]);
                }
                Console.WriteLine("");
            }
        }
        static int [,]MatrixMultiply(int[,] a, int[,] b)
        {
            int row = a.GetLength(0);
            int col = b.GetLength(1);
            int[,] answer = new int[row, col];
            for(int i= 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    int total = 0;
                    for(int k = 0; k < a.GetLength(1); k++)
                    {
                        total = total + (a[i, k] * b[k, j]);
                    }
                    answer[i, j] = total;
                }
            }
            return answer;
        }
    }
}
