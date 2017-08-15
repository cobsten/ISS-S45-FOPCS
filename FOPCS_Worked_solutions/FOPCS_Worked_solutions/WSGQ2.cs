using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class WSGQ2
    {
        static void Main()
        {
            //initialize array
            int[] array = new int[] { 12, 14, 346,  4};
            for(int i = 0; i < array.Length; i++)
            {
                int counter= i,temp=0;
                for(int j = i+1; j < array.Length; j++)
                {
                    if (array[counter] < array[j])
                    {
                        counter = j;
                    }
                }
                temp = array[i];
                array[i] = array[counter];
                array[counter] = temp;
                for(int k=0; k < array.Length; k++) {
                    System.Console.Write("{0}\t", array[k]);
                }
                System.Console.WriteLine("");

            }
        }
    }
}
