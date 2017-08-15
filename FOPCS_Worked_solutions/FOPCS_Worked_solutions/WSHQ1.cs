using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class WSHQ1
    {
        static void Main()
        {
            int test;
            test = ReadInteger();
            System.Console.WriteLine(test);
        }
        //Q1
        static int ReadInteger()
        {
            bool isInteger=false;
            int integer=0;
            do
            {
                Console.WriteLine("Please input an integer");
                isInteger = Int32.TryParse(Console.ReadLine(), out integer);
            } while (isInteger == false);
            return integer;
        }
        
        

        

        //Q4
        
        //Q6
    }
}
