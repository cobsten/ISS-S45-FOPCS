using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class WSHQ5
    {
        static void Main()
        {

            System.Console.Write("Please input your integer: ");
            int input = Int32.Parse(System.Console.ReadLine());
            string hex = DecToHex(input);
            System.Console.WriteLine("Your input is " + hex + " in hexadecimal");

        }
        //Q5
        static string DecToHex(int dec)
        {
            string hex = "";
            do
            {
                switch (dec % 16)
                {
                    case 1:
                        {
                            hex = hex.Insert(0, "1");
                            break;
                        }
                    case 2:
                        {
                            hex = hex.Insert(0, "2");
                            break;
                        }
                    case 3:
                        {
                            hex = hex.Insert(0, "3");
                            break;
                        }
                    case 4:
                        {
                            hex = hex.Insert(0, "4");
                            break;
                        }
                    case 5:
                        {
                            hex = hex.Insert(0, "5");
                            break;
                        }
                    case 6:
                        {
                            hex = hex.Insert(0, "6");
                            break;
                        }
                    case 7:
                        {
                            hex = hex.Insert(0, "7");
                            break;
                        }
                    case 8:
                        {
                            hex = hex.Insert(0, "8");
                            break;
                        }
                    case 9:
                        {
                            hex = hex.Insert(0, "9");
                            break;
                        }
                    case 10:
                        {
                            hex = hex.Insert(0, "a");
                            break;
                        }
                    case 11:
                        {
                            hex = hex.Insert(0, "b");
                            break;
                        }
                    case 12:
                        {
                            hex = hex.Insert(0, "c");
                            break;
                        }
                    case 13:
                        {
                            hex = hex.Insert(0, "d");
                            break;
                        }
                    case 14:
                        {
                            hex = hex.Insert(0, "e");
                            break;
                        }
                    case 15:
                        {
                            hex = hex.Insert(0, "f");
                            break;
                        }
                    default://when 0
                        {
                            hex = hex.Insert(0, "0");
                            break;
                        } 
                }
                dec = dec / 16;
            } while (dec > 0);
            return hex;
        }
    }
}
