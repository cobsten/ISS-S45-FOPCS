using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class _2ndProgram
    {
        static void Main()
        {
            for (int i=1; i < 5; i++){
                for(int j = 1; j < 5; j++)
                {
                    Console.WriteLine("{0}x{1}={2}", i, j, i * j);
                }
            }
        }
    }
}
