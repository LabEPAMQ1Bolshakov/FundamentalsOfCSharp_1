using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calc
    {
        static void Main(string[] args)
        {
            string stayHere = "N";
            while (stayHere != null)
            {
                Console.WriteLine("Choose the type of calculation. Enter +, or -, or *, or / :");
                string typeOfCalc = Console.ReadLine();

                Console.WriteLine("Enter the first number:");
                string str = Console.ReadLine();
                double firstNum = float.Parse(str);

                Console.WriteLine("Enter the second number:");
                str = Console.ReadLine();
                double secondNum = float.Parse(str);

                if (typeOfCalc.Equals("+"))
                {
                    Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, firstNum + secondNum);
                }
                else if (typeOfCalc.Equals("-"))
                {
                    Console.WriteLine("{0} - {1} = {2}", firstNum, secondNum, firstNum - secondNum);
                }
                else if (typeOfCalc.Equals("*"))
                {
                    Console.WriteLine("{0} * {1} = {2}", firstNum, secondNum, firstNum * secondNum);
                }
                else if (typeOfCalc.Equals("/"))
                {
                    Console.WriteLine("{0} / {1} = {2}", firstNum, secondNum, firstNum / secondNum);
                }

                Console.WriteLine("Would you like to make a new calculation?");
                Console.WriteLine("Press Enter to continue");
                Console.WriteLine("Enter N to exit");
                stayHere = Console.ReadLine();
                if (stayHere.Equals("N")) break;                                                            
                            
            } 
        }
    }
}
