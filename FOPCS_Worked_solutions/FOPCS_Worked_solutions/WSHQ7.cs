using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class WSHQ7
    {
        static void Main()
        {
            int[] Array = new int[9];
            SetArray(Array,2);
            for (int i = 0; i < Array.Length; i++)
            {
                System.Console.WriteLine(Array[i]);
            }
        }
        static void SetArray(int[] arr, int value)
        {
            for(int i=0; i < arr.Length; i++)
            {
                arr[i] = value;
            }
            return;
        }
    }
}
