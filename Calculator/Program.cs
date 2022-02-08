using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepAlive = true;
            do
            { 
                double firstNumber = InputDouble("first");
                double secondNumber = InputDouble("second");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Please choose operation (+-/* or q for ending): ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                char operation = Console.ReadKey().KeyChar;

                switch (operation)
                {
                    case '+':
                        Console.WriteLine("\n" + firstNumber + "+" + secondNumber + "=" + Addition(firstNumber, secondNumber));
                        break;
                    case '-':
                        Console.WriteLine("\n" + firstNumber + "-" + secondNumber + "=" + Subtraction(firstNumber, secondNumber));
                        break;
                    case '*':
                        Console.WriteLine("\n" + firstNumber + "*" + secondNumber + "=" + Multiplication(firstNumber, secondNumber));
                        break;
                    case '/':
                        Console.WriteLine("\n" + firstNumber + "/" + secondNumber + "=" + Division(firstNumber, secondNumber));
                        break;
                    case 'q':
                    case 'Q':
                        keepAlive=false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That is not a valid input!");
                        Console.ResetColor();
                        break;
                }
            }
            while (keepAlive);
        }//Main end

        private static double InputDouble(string order)
        {
            bool validDouble;
            double number=0;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Please input {0} number: ", order);
                Console.ForegroundColor = ConsoleColor.DarkGreen;


                try
                {
                    string inputValue = Console.ReadLine();
                    number = double.Parse(inputValue ?? "");
                    validDouble = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a number! Try again;");
                    Console.ResetColor();
                    validDouble = false;
                    number = 0;
                }//catch end
            }
            while (!validDouble);
            return number;
        }
        
        private static double Addition(double number1, double number2)
            {
                return number1+number2;
            }//Addition end
        
        private static double Subtraction(double number1, double number2)
            {
                return number1 - number2;
            }//Subtraktion end
        
        private static double Multiplication(double number1, double number2)
            {
                return number1 * number2;
            }//Multiplication end
        
        private static double Division(double number1, double number2)
            {
                if (number2 == 0)
                {
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("Division with 0"!);
                    Console.ResetColor();
                    return 0;
                }
                else
                 return number1 / number2;
                
            }//division end

        }//Program end
    }//Calculator end


