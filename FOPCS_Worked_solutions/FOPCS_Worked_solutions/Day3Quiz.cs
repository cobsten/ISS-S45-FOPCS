using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Day3Quiz
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Bank of ISS");
            int pin = 123456, userInput = 0;
            for (int count = 1; count <= 3 && pin != userInput; count++)
            {
                Console.Write("Enter your pin: ");
                userInput = Int32.Parse(Console.ReadLine());
                Console.WriteLine("");
                if ((userInput != pin)&&(count<3))
                {
                    Console.WriteLine("Incorrect pin.Please try again.");
                }
                else { }
            }
            if (userInput == pin)
            {
                Console.WriteLine("Pin accepted. You can access your account now");
            }
            else
            {
                Console.WriteLine("Too many wrong pin entries. Your account is now locked");
            }
        }*/
        //alternatively
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Bank of ISS");
            int pin = 123456;
            Boolean correct_Pin = false;
            for (int count = 1; count <= 3 && !correct_Pin; count++)
            {
                Console.Write("Enter your pin: ");
                int userInput = Int32.Parse(Console.ReadLine());
                if (userInput == pin)
                {
                    correct_Pin = true;
                }
                Console.WriteLine("");
                if ((!correct_Pin) && (count < 3))
                {
                    Console.WriteLine("Incorrect pin.Please try again.");
                }
                else { }
            }
            if (!correct_Pin)
            {
                Console.WriteLine("Pin accepted. You can access your account now");
            }
            else
            {
                Console.WriteLine("Too many wrong pin entries. Your account is now locked");
            }
        }
    }
}
