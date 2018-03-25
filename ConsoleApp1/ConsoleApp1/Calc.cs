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
            string stayHere = null;
            while (stayHere == null)
            {
                Console.WriteLine("Choose the type of calculation. Enter +, or -, or *, or / :");
                string typeOfCalc = Console.ReadLine();
                if (typeOfCalc.Equals("+") || typeOfCalc.Equals("-") || typeOfCalc.Equals("*") || typeOfCalc.Equals("/"))
                {
                    Console.WriteLine("Enter the first number:");
                    float firstNum;
                    bool firstTest = float.TryParse(Console.ReadLine(), out firstNum);
                    if (firstTest == true)
                    {
                        Console.WriteLine("Enter the second number:");
                        float secondNum;
                        bool secondTest = float.TryParse(Console.ReadLine(), out secondNum);
                        if (secondTest == true)
                        {
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
                        }
                        else
                        {
                            Console.WriteLine("Wrong input!");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Wrong input!");
                    }

                    
                    Console.WriteLine();
                    Console.WriteLine("Would you like to make a new calculation?");
                    Console.WriteLine("Press any key to continue");
                    Console.WriteLine("Enter Escape to exit");
                    
                    if (Console.ReadKey().Key == ConsoleKey.Escape) break;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Wrong input!");
                }
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
