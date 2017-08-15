using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Workshop2
{
    class WS2CQ1
    {
        static void Main()
        {
            string salutations = "";
            System.Console.WriteLine("Kindly enter your name");
            string name = System.Console.ReadLine();
            //request for gender
            System.Console.WriteLine("Kindly input your gender ( M / F)?");
            string gender = System.Console.ReadLine();
            if (gender == "M")
            {
                salutations = "Mr";
            }
            else if (gender == "F")
            {
                salutations = "Ms";
            }
            System.Console.WriteLine("Good Morning " + salutations + " " + name);
        }
    }
}
