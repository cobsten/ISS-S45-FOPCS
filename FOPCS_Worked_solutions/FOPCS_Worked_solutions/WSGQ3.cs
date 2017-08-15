using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class WSGQ3
    {
        static void Main()
        {
            double[,] studentGrades = new double[12, 4]
            {
                {56,84,68,29},
                {94,73,31,96},
                {41,63,36,90},
                {99,9,18,17},
                {62,3,65,75},
                {40,96,53,23},
                {81,15,27,30},
                {21,70,100,22},
                {88,50,13,12},
                {48,54,52,78},
                {64,71,67,25},
                {16,93,46,72}
            };
            double[,] perStudentTotal_Ave = new double[studentGrades.GetLength(0),2], perSubAve_StdDev = new double[studentGrades.GetLength(1),2];
            //compute total marks (a)
            int numOfStudent = studentGrades.GetLength(0),
                numOfSubs = studentGrades.GetLength(1);

            for(int student = 0; student < numOfStudent; student++)
            {
                double totalGrades = 0;
                for (int subject = 0; subject < (numOfSubs); subject++)
                {
                    totalGrades = totalGrades + studentGrades[student, subject];
                    System.Console.Write(" {0}\t",studentGrades[student, subject]);
                }
                //total grades per student
                perStudentTotal_Ave[student,0] = totalGrades;
                //compute average mark(student)
                perStudentTotal_Ave[student,1] = (totalGrades / numOfSubs);
                System.Console.WriteLine("{0}\t{1}",perStudentTotal_Ave[student,0], perStudentTotal_Ave[student, 1]);
            }
            for (int subject=0; subject < numOfSubs; subject++)
            {
                //average for subject(b)
                double totalSubject = 0, variance=0;
                for(int student = 0; student< numOfStudent; student++)
                {
                    totalSubject = totalSubject + studentGrades[student, subject];
                }
                perSubAve_StdDev[subject,0] = totalSubject / numOfStudent;
                System.Console.WriteLine("The average for subject {0}, is {1}", (subject + 1), perSubAve_StdDev[subject, 0]);
                //std dev for subject(b)
                for(int student = 0; student < numOfStudent; student++)
                {
                    variance = variance + (System.Math.Pow((perSubAve_StdDev[subject, 0] - studentGrades[student,subject]), 2));
                }
                perSubAve_StdDev[subject, 1] = System.Math.Sqrt(variance/numOfStudent);
                System.Console.WriteLine("The Std Dev for subject {0}, is {1}", (subject + 1), perSubAve_StdDev[subject, 1]);
            }
            //
        }

    }

}

