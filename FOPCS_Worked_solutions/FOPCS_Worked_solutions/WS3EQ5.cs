using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class WS3EQ5
    {
        static void Main()
        {
            for (int j = 5; j <= 10000; j++)
            {
                int i;
                for (i = 2; (j % i) != 0 && i < j; i++)
                {
                }
                if (i == j)
                {
                    System.Console.WriteLine("{0} is Prime", j);
                }
            }
        }
    }
}
