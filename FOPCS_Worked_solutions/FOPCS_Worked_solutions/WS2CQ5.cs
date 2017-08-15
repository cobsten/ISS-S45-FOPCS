using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Workshop2
{
    class WS2CQ5
    {
        static void Main()
        {
            int residual, number, firstDigit, secondDigit, thirdDigit;
            double doubleNum;
            System.Console.WriteLine("Please input number");
            number = Int32.Parse(System.Console.ReadLine());
            thirdDigit = number % 10;
            residual = number /10;
            secondDigit = residual % 10;
            residual = residual / 10;
            firstDigit = residual % 10;
            residual = residual / 10;
            doubleNum = System.Convert.ToDouble(number);
            double armstrongCheckNum = System.Math.Pow(firstDigit, 3) + System.Math.Pow(secondDigit, 3) + System.Math.Pow(thirdDigit, 3);
            if (armstrongCheckNum == doubleNum)
            {
                System.Console.WriteLine("True");
            }
            else
            {
                System.Console.WriteLine("False");
            }
        }
    }
}
