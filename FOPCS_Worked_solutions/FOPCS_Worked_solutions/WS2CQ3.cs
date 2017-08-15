using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Workshop2
{
    class WS2CQ3
    {
        static void Main()
        {
            int grade = 0;
            string gradeNum = "";
            System.Console.WriteLine("PLease input your grade");
            grade = Int32.Parse(System.Console.ReadLine());
            if(grade<= 100 && grade >= 80)
            {
                gradeNum = "A";   
            }
            else if (grade<80 && grade >= 60)
            {
                gradeNum = "B";
            }
            else if (grade<60 && grade >= 40)
            {
                gradeNum = "C";
            }
            else if (grade <40 && grade >= 0)
            {
                gradeNum = "F";
            }
            else
            {
                gradeNum = "**Error**";
            }
            System.Console.WriteLine("You scored " + grade + " marks which is " + gradeNum + " grade");
        }
    }
}
