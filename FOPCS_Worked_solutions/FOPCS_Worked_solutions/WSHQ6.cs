using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class WSHQ6
    {
        static void Main()
        {
            System.Console.WriteLine(Substitute("the quick brown fox", 'x', 'u'));
        }
        //Q6
        /*
        //using insert and remove
        static string Substitute(string s, char c1, char c2)
        {
            for(int i =0 ; i < s.Length; i++)
            {
                if (s[i] == c1)
                {
                    s=s.Remove(i, 1);
                    s=s.Insert(i, c2.ToString());
                }
            }
            return s;
        }
        */
        //using split
        static string Substitute(string s, char c1, char c2)
        {
            string[] temp = s.Split(c1);
            string x = "";
            for(int i = 0; i < temp.Length-1; i++)
            {
                temp[i] = temp[i]+c2;
            }
            int j = 0,pos=0;
            while( j < temp.Length){
                x = x.Insert(pos, temp[j]);
                pos = pos + temp[j].Length;
                j++;
            }
            return x;
        }
    }
}
