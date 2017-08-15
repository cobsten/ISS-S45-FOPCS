using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class WS3DQ4
    {
        static void Main()
        {
            System.Console.WriteLine("Please key in a number");
            int N = Int32.Parse(System.Console.ReadLine());
            Random r = new Random();
            double guess = 0;
            if (N > 0)
            {
                guess = r.Next(1, N);
            }
            //while((guess*guess - N) > 0.00001 || (guess*guess - N) < -0.00001)
            while(System.Math.Abs(guess*guess-N)>0.00001)
            {
                guess = (guess + (N / guess)) / 2;
            }
            System.Console.WriteLine("The square root of {0} is {1:0.###}",N,guess);

        }
    }
}
