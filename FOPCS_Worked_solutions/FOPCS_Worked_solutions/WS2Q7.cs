using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Workshop2
{
    class WS2Q7
    {
        static void Main()
        {
            double minCharge = 2.4, costPerKm = 0.4;
            double distance = System.Convert.ToDouble(System.Console.ReadLine());
            double fare = minCharge + distance * costPerKm;
            System.Console.WriteLine(fare);
        }
    }
}
