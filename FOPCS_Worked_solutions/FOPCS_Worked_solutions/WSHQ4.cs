using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class WSHQ4
    {
        static void Main()
        {
            string s1 = "", s2 = "";
            System.Console.WriteLine("Please input string");
            s1 = System.Console.ReadLine();
            System.Console.WriteLine("Please input string you want to find");
            s2 = System.Console.ReadLine();
            int sPos = InString(s1, s2);
            System.Console.WriteLine(sPos);
        }
        static int InString(string s1, string s2)
        {
            bool isStringIn = false;
            int sPos = -1, j =0;
            s1 = s1.ToLower();
            s2 = s2.ToLower();
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s2[j])
                {
                    if (j == (s2.Length - 1))
                    {
                        isStringIn = true;
                        sPos = i - s2.Length + 1;
                        break;
                    }
                    j++;
                }
                else
                {
                    j = 0;
                }
            }
            return sPos;
        }
    }
}
