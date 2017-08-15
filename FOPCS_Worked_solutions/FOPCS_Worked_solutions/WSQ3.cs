using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class WSQ3
    {
        static void Main()
        {
            Console.WriteLine("Please input a number");
            int Temp = Convert.ToInt32(Console.ReadLine());
            Temp = Temp * Temp;
            Console.WriteLine("{0}",Temp);
        }
    }
}
