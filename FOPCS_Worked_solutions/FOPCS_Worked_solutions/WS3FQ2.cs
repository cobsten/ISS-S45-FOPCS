using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class WS3FQ2
    {
        static void Main()
        {
            System.Console.WriteLine("Please input your word");
            string userInput = System.Console.ReadLine();
            userInput = userInput.ToLower();
            string compareString = "";
            int compareIndex = 0;
            for (int i = userInput.Length -1 ; i >= 0; i--)
            {
                compareString = compareString.Insert(compareIndex,userInput.Substring(i,1));
                compareIndex++;
            }
            if (compareString.Equals(userInput))
            {
                System.Console.WriteLine("Is a pallindrome");
            }
            else
            {
                System.Console.WriteLine("Is not a pallindrome");
            }
        }
    }
}
