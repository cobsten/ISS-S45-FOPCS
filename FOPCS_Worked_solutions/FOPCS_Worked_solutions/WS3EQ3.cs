using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class WS3EQ3
    {
        static void Main()
        {
            System.Console.WriteLine("Please Input a number");
            int i;
            int userInput= Int32.Parse(System.Console.ReadLine());
            for(i=2;(userInput%i)!=0&&i<userInput;i++)
            {
            }
            if (i == userInput)
            {
                System.Console.WriteLine("Prime");
            }
            else
            {
                System.Console.WriteLine("Not Prime");
            }

        }
    }
}
