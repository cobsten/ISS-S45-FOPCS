using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class WS4FQ4
    {
        static void Main()
        {
            System.Console.WriteLine("Please input your sentence");
            int letterPlacement = 0;
            string titleCase = "";
            string userInput = System.Console.ReadLine();
            //to lowercase all
            userInput = userInput.ToLower();
            //create array to hold words
            string [] tempArray = userInput.Split(' ');
            for(int i = 0; i < tempArray.Length; i++)
            {
                //initialize strings for first letter and rest of word
                string firstLetter = "", word = "";
                firstLetter = tempArray[i].Substring(0, 1);
                word = tempArray[i].Substring(1, tempArray[i].Length - 1);
                //make first letter UPPERCASE
                firstLetter = firstLetter.ToUpper();
                //insert back into word
                word = word.Insert(0, firstLetter);
                //placement back into output string
                titleCase =titleCase.Insert(letterPlacement, word);
                letterPlacement = letterPlacement + word.Length;
                //for spacing
                if (i < (tempArray.Length - 1))
                {
                    titleCase = titleCase.Insert(letterPlacement, " ");
                    letterPlacement++;
                }
            }
            System.Console.WriteLine(titleCase);
        }
    }
}
