using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class WSHQ9
    {
        static void Main()
        {
            for(int i=5; i < 1000; i++)
            {
                if (IsPrime(i))
                {
                    System.Console.WriteLine(i);
                }
            }
        }
        static bool IsPrime(int n)
        {
            int i = 2;
            bool isPrimeTrue = true;
            do
            {
                if (n % i == 0)
                {
                    isPrimeTrue = false;
                }
                i++;
            } while (i < n && (isPrimeTrue));
            return isPrimeTrue;
        }
    }
}
