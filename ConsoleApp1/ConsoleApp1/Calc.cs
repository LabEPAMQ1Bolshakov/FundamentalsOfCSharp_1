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
                float firstNum = float.Parse(str);

                Console.WriteLine("Enter the second number:");
                str = Console.ReadLine();
                float secondNum = float.Parse(str);

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

                Console.WriteLine("Would you like to make a new calculation?");
                Console.WriteLine("Press Enter to continue");
                Console.WriteLine("Enter N to exit");
                stayHere = Console.ReadLine();
                if (stayHere.Equals("N")) break;                                                            
                            
            } 
        }

        static void AddNumbers(float x, float y)
        {
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
        }

        static void SubNumbers(float x, float y)
        {
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
        }

        static void MultNumbers(float x, float y)
        {
            Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
        }

        static void DivNumbers(float x, float y)
        {
            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
        }
    }
}
