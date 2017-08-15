using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class WS3DQ2
    {
        static void Main()
        {
            int num1, num2,testNum1,testNum2;
            bool check = false;
            System.Console.WriteLine("Please key in two numbers");
            check = Int32.TryParse(System.Console.ReadLine(), out num1);
            check = Int32.TryParse(System.Console.ReadLine(), out num2);
            testNum1 = num1;
            testNum2 = num2;

            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    //Subtract the smaller of the two numbers from the Larger Number and assign the answer to the larger number
                    num1 = num1 - num2;
                }
                else
                {
                    num2 = num2 - num1;
                }
            }
            //write to screen HCF
            System.Console.WriteLine("This is the HCF " + num1);
            // write to screen: (A*B)/HCF
            System.Console.WriteLine("THis is the LCM " + ((testNum1 * testNum2) / num1));

        }
    }
}
