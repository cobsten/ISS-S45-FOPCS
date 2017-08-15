using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class WS4FQ6
    {
        static void Main()
        {
            System.Console.Write("Write a matriculation number: ");
            bool isValid = true;
            string matricNo = System.Console.ReadLine();
            if (matricNo.Length == 7)
            {
                matricNo = matricNo.ToUpper();
                if (matricNo.Substring(0, 1) == "A")
                {
                    string matricString = matricNo.Substring(1, 5);
                    int[] matricNumbers =new int[5];
                    int i = 0, checksum = 0;
                    //taking all digits and multiplying
                    while (i < matricString.Length && isValid)
                    {
                        isValid = Int32.TryParse(matricString.Substring(i, 1), out matricNumbers[i]);
                        matricNumbers[i] = matricNumbers[i] * (6 - i);
                        i++;
                    }
                    //calculate the sum
                    for ( i = 0; i < matricNumbers.Length; i++)
                    {
                        checksum = checksum + matricNumbers[i];
                    }
                    //checking against last letter
                    switch (checksum % 5)
                    {
                        case 0:
                            if (matricNo.Substring((matricNo.Length-1),1)!= "O"){
                                isValid = false;
                            }       
                            break;
                        case 1:
                            if(matricNo.Substring((matricNo.Length - 1), 1) != "P"){
                                isValid = false;
                            }
                            break;
                        case 2:
                            if (matricNo.Substring((matricNo.Length - 1), 1) != "Q")
                            {
                                isValid = false;
                            }
                            break;
                        case 3:
                            if (matricNo.Substring((matricNo.Length - 1), 1) != "R")
                            {
                                isValid = false;
                            }
                            break;
                        case 4:
                            if (matricNo.Substring((matricNo.Length - 1), 1) != "S")
                            {
                                isValid = false;
                            }
                            break;
                        default:
                            isValid = false;
                            break;
                    }
                }
                else
                {
                    isValid = false;
                }
            }
            else
            {
                isValid = false;
            }
            if (isValid)
            {
                System.Console.WriteLine("Valid");
            }
            else
            {
                System.Console.WriteLine("Invalid");
            }
        }
    }
}
