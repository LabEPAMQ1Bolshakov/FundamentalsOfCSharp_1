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
            Calculation(); 
        }

        static void Calculation()
        {
            string stayHere = null;
            while (stayHere == null)
            {
                Console.WriteLine("Choose the type of calculation. Enter +, or -, or *, or / :");
                string typeOfCalc = Console.ReadLine();
                while ((typeOfCalc.Equals("+") || typeOfCalc.Equals("-") || typeOfCalc.Equals("*") || typeOfCalc.Equals("/")) == false)
                {
                    Console.WriteLine("Wrong input!");
                    Console.WriteLine("Choose the type of calculation. Enter +, or -, or *, or / :");
                    typeOfCalc = Console.ReadLine();
                }

                Console.WriteLine("Enter the first number:");
                double firstNum;
                string str = Console.ReadLine();
                while (Double.TryParse(str, out firstNum) == false)
                {
                    Console.WriteLine("Wrong input!");
                    Console.WriteLine("Enter the first number:");
                    str = Console.ReadLine();
                }

                Console.WriteLine("Enter the second number:");
                double secondNum;
                str = Console.ReadLine();
                while (Double.TryParse(str, out secondNum) == false)
                {
                    Console.WriteLine("Wrong input!");
                    Console.WriteLine("Enter the second number:");
                    str = Console.ReadLine();
                }

                if (typeOfCalc.Equals("+"))
                {
                    AddNumbers(firstNum, secondNum);
                }
                else if (typeOfCalc.Equals("-"))
                {
                    SubNumbers(firstNum, secondNum);
                }
                else if (typeOfCalc.Equals("*"))
                {
                    MultNumbers(firstNum, secondNum);
                }
                else if (typeOfCalc.Equals("/"))
                {
                    DivNumbers(firstNum, secondNum);
                }
                
                Console.WriteLine("\nWould you like to make a new calculation?");
                Console.WriteLine("Press any key to continue");
                Console.WriteLine("Enter Escape to exit\n");

                if (Console.ReadKey().Key == ConsoleKey.Escape) break;
            }
        }

        static void AddNumbers(double x, double y)
        {
            Console.WriteLine("\n{0} + {1} = {2}", x, y, x + y);
        }

        static void SubNumbers(double x, double y)
        {
            Console.WriteLine("\n{0} - {1} = {2}", x, y, x - y);
        }

        static void MultNumbers(double x, double y)
        {
            Console.WriteLine("\n{0} * {1} = {2}", x, y, x * y);
        }

        static void DivNumbers(double x, double y)
        {
            Console.WriteLine("\n{0} / {1} = {2}", x, y, x / y);
        }
    }
}
