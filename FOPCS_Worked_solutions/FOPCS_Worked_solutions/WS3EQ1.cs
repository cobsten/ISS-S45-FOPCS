using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class WS3EQ1
    {
        static void Main()
        {
            System.Console.WriteLine("Please Write a number");
            /*
            //mistaken assumption of factorial
            int factorial=1, result = 1;
            int userInput = Int32.Parse(System.Console.ReadLine());
            for (result = 1; (result != userInput)&&(result<userInput); factorial++)
            {
                result = result * factorial;
            }
            */
            int userInput = Int32.Parse(System.Console.ReadLine());
            int factorial, result=1;
            /*
            //ascending
            for (factorial = 1; factorial <= userInput; factorial++)
            {
                result = result * factorial;
            }
            */
            //descending
            for (factorial = userInput; factorial > 0; factorial--)
            {
                result = result * factorial;
            }
            
            System.Console.WriteLine("The factorial is {0}", result);
            
        }
    }
}
