using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Workshop2
{
    class WS2Q10
    {
        static void Main()
        {
            //To get values of all three sides
            System.Console.WriteLine("Please key values of a");
            double a = Double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Please key values of b");
            double b = Double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Please key values of c");
            double c = Double.Parse(System.Console.ReadLine());
            //compute s
            double s = (a + b + c) / 2;
            double areaSquared = s * (s - a) * (s - b) * (s - c);
            //check if negative else proceed
            if (areaSquared < 0 ){
                System.Console.WriteLine("Impossible condition");
            }
            else
            {
                System.Console.WriteLine(System.Math.Sqrt(areaSquared));
            }

        }
    }
}
