using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Workshop2
{
    class WS2Q5
    {
        static void Main ()
        {
            double x = System.Convert.ToDouble(System.Console.ReadLine());
            double y = 5 * (System.Math.Pow(x,2)) - (4 * x) + 3;
            //          int y = 5 * (x 2) - (4 * x) + 3;
            System.Console.WriteLine(y);
        }
    }
}
