using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class WS4FQ5
    {
        static void Main()
        {
            //input for string and score
            string[] names = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] score = new int[] { 63, 29, 75, 82, 55 };
            //can create for loop to make all words lowercase so comparison is accurate
            //part a
            for (int i = 0; i < names.Length; i++)
            {
                int counter = i, scoreHolder = 0;
                string nameHolder = "";
                for (int j = i + 1; j < names.Length; j++)
                {
                    if (score[j] > score[counter])
                    {
                        counter = j;
                    }
                }
                scoreHolder = score[i];
                score[i] = score[counter];
                score[counter] = scoreHolder;
                nameHolder = names[i];
                names[i] = names[counter];
                names[counter] = nameHolder;
                System.Console.WriteLine("{0}\t{1}", names[i], score[i]);
            }
            //part b
            System.Console.WriteLine("****************************************");
            for (int i = 0; i < names.Length; i++)
            {
                int counter = i, scoreHolder = 0;
                string nameHolder = "";
                for (int j = i + 1; j < names.Length; j++)
                {
                    //alphabetically, if S.compareTo(R) > 1 , S is later in the alphabet
                    if (names[j].CompareTo(names[counter]) < 1)
                    {
                        counter = j;
                    }
                }
                scoreHolder = score[i];
                score[i] = score[counter];
                score[counter] = scoreHolder;
                nameHolder = names[i];
                names[i] = names[counter];
                names[counter] = nameHolder;
                System.Console.WriteLine("{0}\t{1}", names[i], score[i]);
            }
        }
    }
}
