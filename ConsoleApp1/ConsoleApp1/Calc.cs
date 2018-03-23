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
            string stay;
            do
            {
                Console.WriteLine("Choose the type of calculation. Enter +, or -, or *, or / :");
                string typeOfCalc = Console.ReadLine();

                Console.WriteLine("Enter the first number:");
                string str = Console.ReadLine();
                double firstNum = double.Parse(str);

                Console.WriteLine("Enter the second number:");
                str = Console.ReadLine();
                double secondNum = double.Parse(str);

                if (typeOfCalc == "+")
                {
                    Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, firstNum + secondNum);
                }
                else if (typeOfCalc == "-")
                {
                    Console.WriteLine("{0} - {1} = {2}", firstNum, secondNum, firstNum - secondNum);
                }
                else if (typeOfCalc == "*")
                {
                    Console.WriteLine("{0} * {1} = {2}", firstNum, secondNum, firstNum * secondNum);
                }
                else if (typeOfCalc == "/")
                {
                    Console.WriteLine("{0} / {1} = {2}", firstNum, secondNum, firstNum / secondNum);
                }

                Console.WriteLine("Would you like to make a new calculation?(enter 'y' to continue):");
                stay = Console.ReadLine();
            } while (stay == "y");
        }
    }
}
