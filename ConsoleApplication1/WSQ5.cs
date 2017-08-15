using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class WSQ5
    {
        static void Main()
        {
            System.Console.WriteLine("Please input a number with decimal");
            Double Temp = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("{0:#.00}", Temp);
        }
    }
}
