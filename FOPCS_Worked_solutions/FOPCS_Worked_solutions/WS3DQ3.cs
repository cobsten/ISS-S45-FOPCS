using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class WS3DQ3
    {
        static void Main()
        {
            Random r = new Random();
            int answer = r.Next(0, 10), userAnswer, numOfGuess=0;
            System.Console.WriteLine("PLease think of a number between 0 - 9");
            do
            {
                if (numOfGuess == 0)
                {
                    System.Console.WriteLine("Please input this number");
                }
                else
                {
                    System.Console.WriteLine("Try Again");
                }
                userAnswer = Int32.Parse(System.Console.ReadLine());
                numOfGuess++;
            } while (userAnswer != answer);
            if (numOfGuess <= 2)
            {
                System.Console.WriteLine("You're a wizard, Harry");
            }
            else
            {
                System.Console.WriteLine("You are lousy");
            }
            //System.Console.WriteLine("You took {0} guesses this time", numOfGuess);
        }
    }
}
