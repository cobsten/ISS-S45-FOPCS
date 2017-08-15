using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Workshop2
{
    class WS2Q9
    {
        static void Main()
        {
                double minCharge = 2.4, costPerKm = 0.4;
                double distance = System.Double.Parse(System.Console.ReadLine());
                double fare = minCharge + distance * costPerKm;
                double roundFare = (System.Math.Ceiling(fare * 10)) / 10;
                System.Console.WriteLine("{0:#.0}", roundFare);
        }
    }
}
