using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class WS3EQ2
    {
        static void Main()
        {
            System.Console.WriteLine("NO\t\tINVERSE\t\tSQUARE ROOT\tSQUARE");
            for (double i = 1; i <= 10; i++)
            {
                System.Console.Write("{0:0.0##}",i);
                System.Console.Write("\t\t{0:0.0##}", (1 / i));
                System.Console.Write("\t\t{0:0.0##}", (System.Math.Sqrt(i)));
                System.Console.WriteLine("\t\t{0:0.0##}", (i * i));
            }
        }
    }
}
