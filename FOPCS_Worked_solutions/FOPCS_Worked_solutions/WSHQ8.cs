using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class WSHQ8
    {
        static void Main()
        {
            int[] array = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.WriteLine(array[i]);
            }
            System.Console.WriteLine("After......");
            array = ResizeArray(array, 7);
            for(int i = 0; i < array.Length; i++)
            {
                System.Console.WriteLine(array[i]);
            }
        }
        static int[] ResizeArray(int [] arr, int newSize)
        {
            int [] copy = new int[newSize];
            for(int i = 0; i< newSize; i++)
            {
                if ((i < arr.Length)&&(i<newSize))
                {
                    copy[i] = arr[i];
                }
                else if(copy.Length>arr.Length)
                {
                    copy[i] = 0;
                }
            }
            return copy;
        }
    }
}
