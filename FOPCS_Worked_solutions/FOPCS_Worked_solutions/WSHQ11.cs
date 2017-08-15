using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class WSHQ11
    {
        static void Main()
        {
            double[] array = { 1, 2, 3, 4, 5, 6, 7 };
            DoubleOps ops = System.Math.Sqrt;
            array = ProcessArray(array, ops);
            PrintArray(array);
            ops = Square;
            array = ProcessArray(array, ops);
            array = ProcessArray(array, ops);
            PrintArray(array);

        }
        delegate double DoubleOps(double x);
        static double [] ProcessArray(double[] arr,DoubleOps ops)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = ops(arr[i]);
            }
            return arr;
        }
        
        static double Square(double x)
        {
            x = x * x;
            return x;
        }
        static void PrintArray(double[] Array)
        {
            for(int i = 0; i < Array.Length; i++)
            {
                System.Console.Write("{0:###.###} ", Array[i]);
            }
            Console.WriteLine();
        }
    }
}
