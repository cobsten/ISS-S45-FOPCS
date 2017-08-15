using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class WS3EQ6
    {
        static void Main()
        {
            for(int j=1; j <= 1000; j++)
            {
                int i, total = 0;
                for (i = 1; i < j; i++)
                {
                    if ((j % i) == 0)
                    {
                        total += i;
                    }
                }
                if (total == j)
                {
                    System.Console.WriteLine("{0} is a Perfect Number",j);
                }

            }
        }
    }
}
