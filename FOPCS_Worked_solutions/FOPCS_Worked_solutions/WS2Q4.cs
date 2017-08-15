using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Workshop2
{
    class WS2Q4
    {
        static void Main()
        {
            double celcius = System.Convert.ToDouble(System.Console.ReadLine());
            double fahrenheit = celcius * 1.8 + 32;
            System.Console.WriteLine(fahrenheit);
        }
    }
}
