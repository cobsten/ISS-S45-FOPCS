using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class WS4FQ3
    {
        static void Main()
        {
            System.Console.WriteLine("Please input your sentence");
            string compareString = "",processInput="",userInput = System.Console.ReadLine();
            userInput = userInput.ToLower();
            int placement = 0;
            string[] tempArray= userInput.Split(' ');
            for (int i = 0; i < tempArray.Length; i++)
            {
                processInput = processInput.Insert(placement, tempArray[i]);
                placement = placement + tempArray[i].Length;
            }
//            System.Console.WriteLine(processInput);
///*
            int compareIndex = 0;
            for (int i = processInput.Length - 1; i >= 0; i--)
            {
                compareString = compareString.Insert(compareIndex, processInput.Substring(i, 1));
                compareIndex++;
            }
            if (compareString.Equals(processInput))
            {
                System.Console.WriteLine("Is a pallindrome");
            }
            else
            {
                System.Console.WriteLine("Is not a pallindrome");
            }
//*/
        }
    }
}
