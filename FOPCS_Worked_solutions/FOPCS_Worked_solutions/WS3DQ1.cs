using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class WS3DQ1
    {
        static void Main(string[] args)
        {
            int value = 88, checkValue=0;
            bool check = false;
            do
            {
                System.Console.WriteLine("Please enter an integer");
                check = Int32.TryParse(System.Console.ReadLine(), out checkValue);
            } while (value != checkValue);
            System.Console.WriteLine("Lucky you...");
        }
    }
}
