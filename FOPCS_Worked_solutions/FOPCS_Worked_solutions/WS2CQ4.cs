using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Workshop2
{
    class WS2CQ4
    {
        static void Main()
        {
            double minCharge = 2.4,minDist= 5, sRate=0.04, lRate=0.05, totalCharge=0, distance;
            System.Console.WriteLine("Kindly key in the distance travelled");
            distance = Double.Parse(System.Console.ReadLine());
            double distLeft = (System.Math.Ceiling(distance * 10));
            distLeft = distLeft - minDist;
            if (distLeft > 85)
            {
                distLeft = distLeft - 85;
                totalCharge = minCharge + 85 * sRate + distLeft * lRate;
            }
            else if (distLeft>0 && distLeft<= 85)
            {
                totalCharge = minCharge + sRate * distLeft;
            }
            System.Console.WriteLine(totalCharge);
        }
    }
}
