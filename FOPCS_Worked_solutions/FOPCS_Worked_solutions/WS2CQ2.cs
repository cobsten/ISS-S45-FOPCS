using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Workshop2
{
    class WS2CQ2
    {
        static void Main()
        {
            double age = 0;
            string name, gender, salutations="";
            Console.WriteLine("Kindly input your name");
            name = Console.ReadLine();
            Console.WriteLine("Kindly input your gender (M/F)?");
            gender = Console.ReadLine();
            Console.WriteLine("Kindly input your age");
            age = Double.Parse(Console.ReadLine());
            if (age > 40)
            {
                if (gender == "M")
                {
                    salutations = "Uncle ";
                }
                else
                {
                    salutations = "Auntie ";
                }
            }
            else
            {
                if (gender == "M")
                {
                    salutations = "Mr ";
                }
                else
                {
                    salutations = "Ms ";
                }
            }
            //result output
            Console.WriteLine("Good Morning " + salutations + name);
        }
    }
}
