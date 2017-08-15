using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class WS3FQ1
    {
        static void Main()
        {
            System.Console.WriteLine("Please write a phrase");
            string userInput = System.Console.ReadLine();
            userInput = userInput.ToLower();
            int a = 0, e = 0, i = 0, o=0,u= 0, counter =0;
            for (counter = 0; counter < userInput.Length; counter++)
            {
                string s = (userInput.Substring(counter, 1));
                if (s.Equals("a"))
                {
                    a++;
                }
                else if (s.Equals("e"))
                {
                    e++;
                }
                else if (s.Equals("i"))
                {
                    i++;
                }
                else if (s.Equals("o"))
                {
                    o++;
                }
                else if (s.Equals("u"))
                {
                    u++;
                }
                else { }
            }
            System.Console.WriteLine("Total vowels: {0}", (a+ e + i + o + u));
            System.Console.WriteLine("A:{0}", a);
            System.Console.WriteLine("E:{0}", e);
            System.Console.WriteLine("I:{0}", i);
            System.Console.WriteLine("O:{0}", o);
            System.Console.WriteLine("U:{0}", u);
        }
    }
}
