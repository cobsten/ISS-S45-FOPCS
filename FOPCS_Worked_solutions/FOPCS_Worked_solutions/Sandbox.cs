using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Sandbox
    {
        static void Main()
        {
            string s = "  %% abc ,,  ";
            string r = "x";
            Console.WriteLine(s.CompareTo(r));
            s = s.Trim();
            Console.WriteLine("*" + s + "*");
            //s = s.Trim({'%',','}); // does not work; array might need to be predefined
        }
    }
}
