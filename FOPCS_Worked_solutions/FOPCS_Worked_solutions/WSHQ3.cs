using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class WSHQ3
    {
        static void Main()
        {
            string s1 = "", s2 = "";
            System.Console.WriteLine("Please input string");
            s1= System.Console.ReadLine();
            System.Console.WriteLine("Please input string you want to find");
            s2 = System.Console.ReadLine();
            System.Console.WriteLine(InString(s1, s2));
        }
        //Q3
        static bool InString(string s1, string s2)
        {
            int j = 0;
            bool isStringIn = false;
            s1 = s1.ToLower();
            s2 = s2.ToLower();
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s2[j])
                {
                    if (j == (s2.Length - 1))
                    {
                        isStringIn = true;
                        break;
                    }
                    j++;
                }
                else
                {
                    j = 0;
                }
            }
            return isStringIn;
        }
    }
}
