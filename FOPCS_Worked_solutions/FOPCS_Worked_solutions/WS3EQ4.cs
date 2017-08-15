using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class WS3EQ4
    {
        static void Main()
        {
            System.Console.WriteLine("Please Input a number");
            int userInput = Int32.Parse(System.Console.ReadLine());
            int i, total = 0;
            for (i = 1; i < userInput; i++)
            {
                if ((userInput % i) == 0)
                {
                    total += i;
                }
            }
            if (total == userInput)
            {
                System.Console.WriteLine("Perfect Number");
            }
            else
            {
                System.Console.WriteLine("Not a Perfect Number");
            }
        }
    }
}
