using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class WSGQ1
    {
        static void Main()
        {
            //initialize variables
            double[] monthlySales = new double[12];
            //to take in sales for the 12 months (a)
            for(int i = 0; i < monthlySales.Length; i++)
            {
                System.Console.WriteLine("Please key in sales for the month");
                monthlySales[i] = Int32.Parse(System.Console.ReadLine());
            }
            //print the month when maximum/minimum sales is recorded (b/c)
            int maxSaleMonth = 0, minSaleMonth = 0;
            for(int i = 0; i < monthlySales.Length; i++)
            {
                if (monthlySales[maxSaleMonth] < monthlySales[i])
                {
                    maxSaleMonth = i;
                }
                if (monthlySales[minSaleMonth] > monthlySales[i])
                {
                    minSaleMonth = i;
                }
            }
            System.Console.WriteLine("Max sales month is {0}, Min Sales Month is {1}", maxSaleMonth, minSaleMonth);
            //print average monthly sales for the year
            double yearlySales = 0;
            for(int i = 0; i < monthlySales.Length; i++)
            {
                yearlySales = yearlySales + monthlySales[i];
            }
            System.Console.WriteLine("The average monthly sales is {0}", (yearlySales / monthlySales.Length));
        }
    }
}
