using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Workshop2
{
    class WS2Q6
    {
        static void Main ()
        {
            double x1 = System.Convert.ToDouble(System.Console.ReadLine());
            double y1 = System.Convert.ToDouble(System.Console.ReadLine());
            double x2 = System.Convert.ToDouble(System.Console.ReadLine());
            double y2 = System.Convert.ToDouble(System.Console.ReadLine());
            double xDistSq = System.Math.Pow((x2 - x1), 2);
            double yDistSq = System.Math.Pow((y2 - y1), 2);
            double distance = System.Math.Sqrt(xDistSq + yDistSq);
            System.Console.WriteLine(distance);
        }
    }
}
