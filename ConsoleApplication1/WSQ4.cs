using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class WSQ4
    {
        static void Main()
        {
            Console.WriteLine("Please input a number with a decimal point");
            String Temp = System.Console.ReadLine();
            Double tempo = Convert.ToDouble(Temp);
            tempo = tempo * tempo;
            Console.WriteLine("The square of the number is {0}", tempo);
        }
    }
}
