using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Workshop2
{
    class WS2Q2
    {
        static void Main()
        {
            double input = System.Convert.ToDouble(System.Console.ReadLine());
            double inputSqrt = System.Math.Sqrt(input);
            System.Console.WriteLine("{0:#.000 }", inputSqrt);
        }
    }
}
