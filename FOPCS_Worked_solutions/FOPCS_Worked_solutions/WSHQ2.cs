using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class WSHQ2
    {
        static void Main()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 ,6,7,8,9,0,11,12,13,14,15};
            PrintArry(arr);
        }
        //Q2
        static void PrintArry(int[] arr)
        {
            int numCol = 3, j = 0; ;
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("{0}\t", arr[i]);
                if (j == numCol-1)
                {
                    System.Console.WriteLine("");
                    j = 0;
                }
                else
                {
                    j++;
                }
            }
            return;
        }
    }
}
