using System;

namespace Calculator
{
    internal class Calculator
    {
        static void Main(string[] args)

        {
            while (true)
            {
                Console.Clear();
                double firstDigit, secondDigit;
                string action;

                try
                {
                    Console.WriteLine("Please enter the first digit!");
                    firstDigit = double.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter the second digit!");
                    secondDigit = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Incorrect data, press enter to start again!");
                    Console.ResetColor();
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Please select the action on the numbers: '+','-','*','/'");
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstDigit + secondDigit);
                        break;
                    case "-":
                        Console.WriteLine(firstDigit - secondDigit);
                        break;
                    case "*":
                        Console.WriteLine(firstDigit * secondDigit);
                        break;
                    case "/":
                        if (secondDigit == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("You can't divide by zero!");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine(firstDigit / secondDigit);
                        }
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Your action is not recognized, please do another action!");
                        Console.ResetColor();
                        break;
                }
                Console.ReadLine();
            }




        }
    }
}
