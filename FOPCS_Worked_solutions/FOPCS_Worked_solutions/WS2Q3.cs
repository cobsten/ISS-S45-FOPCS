using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Workshop2
{
    class WS2Q3
    {
        static void Main()
        {
            Double salary = System.Convert.ToDouble(System.Console.ReadLine());
            Double totalIncome = salary * 1.13;
            System.Console.WriteLine("{0:c}", totalIncome);
        }
    }
}
