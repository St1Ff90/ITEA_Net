using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_2
{
    class Program
    {
        private static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            for (int i = 0; i < Console.WindowWidth; i++)
                Console.Write(" ");
            Console.SetCursorPosition(0, currentLineCursor);
        }

        private static double Summ(double A, double B)
        {
            if (A > B)
            {
                return A + B;
            }
            if (A == B)
            {
                return A * B;
            }
            if (A < B)
            {
                return A - B;
            }
            return 0;
        }

        private static int PointCoordinates(double x, double y)
        {
            switch (true)
            {
                case true when x < 0 && y < 0:
                    return 3;
                case true when x < 0 && y > 0:
                    return 2;
                case true when x > 0 && y < 0:
                    return 4;
                case true when x > 0 && y > 0:
                    return 1;
                case true when x == 0 || y == 0:
                    return 0;
                default:
                    throw new Exception("Something went wrong!");
            }
        }

        private static void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }


        private static void SortThreeDigits(ref double first, ref double second, ref double third)
        {
            if (first > second)
            {
                Swap(ref first, ref second);
            }
            if (second > third)
            {
                Swap(ref second, ref third);
            }
            if (first > second)
            {
                Swap(ref first, ref second);
            }
        }

        private static (double x1, double x2) QuadraticEquation(double a, double b, double c)
        {
            double x1, x2;
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                x1 = x2 = 0;
            }
            else
            {
                if (discriminant == 0)
                {
                    x1 = x2 = -b / (2 * a);
                }
                else
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                }
            }
            return (x1, x2);
        }

        private static string WriteNumber(int num)
        {
            string result = null;

            if (num >= 20)
            {
                if (num / 10 * 10 == 20)
                {
                    result += "twenty ";
                }
                if (num / 10 * 10 == 30)
                {
                    result += "thirty ";
                }
                if (num / 10 * 10 == 40)
                {
                    result += "forty ";
                }
                if (num / 10 * 10 == 50)
                {
                    result += "fifty ";
                }
                if (num / 10 * 10 == 60)
                {
                    result += "sixty ";
                }
                if (num / 10 * 10 == 70)
                {
                    result += "seventy ";
                }
                if (num / 10 * 10 == 80)
                {
                    result += "eighty ";
                }
                if (num / 10 * 10 == 90)
                {
                    result += "ninety ";
                }
                if (num % 10 == 0)
                {
                    result += "";
                }
                if (num % 10 == 1)
                {
                    result += "one";
                }
                if (num % 10 == 2)
                {
                    result += "rwo";
                }
                if (num % 10 == 3)
                {
                    result += "three";
                }
                if (num % 10 == 4)
                {
                    result += "four";
                }
                if (num % 10 == 5)
                {
                    result += "five";
                }
                if (num % 10 == 6)
                {
                    result += "six";
                }
                if (num % 10 == 7)
                {
                    result += "seven";
                }
                if (num % 10 == 8)
                {
                    result += "eight";
                }
                if (num % 10 == 9)
                {
                    result += "nine";
                }
            }

            else if (num < 20)
            {
                switch (true)
                {
                    case true when num == 10:
                        result = "ten";
                        break;
                    case true when num == 11:
                        result = "eleven";
                        break;
                    case true when num == 12:
                        result = "twelve";
                        break;
                    case true when num == 13:
                        result = "thirteen";
                        break;
                    case true when num == 14:
                        result = "fourteen";
                        break;
                    case true when num == 15:
                        result = "fifteen";
                        break;
                    case true when num == 16:
                        result = "sixteen";
                        break;
                    case true when num == 17:
                        result = "seventeen";
                        break;
                    case true when num == 18:
                        result = "eighteen";
                        break;
                    case true when num == 19:
                        result = "nineteen";
                        break;
                    default:
                        result = "Error!";
                        break;
                }
            }
            else
            {
                result = "Error!";
            }

            return result;
        }

        static void Main(string[] args)
        {
            string[] menuItems = new string[] { "Summ (1)", "Point Coordinates (2)", "Sort Three Digits (3)", "Quadratic Equation (4)", "Write Number (5)" };
            int menuItemIndex = 5;
            Console.WriteLine("Main menu. \nUse buttons up/down to move and Enter to confirm you choose");

            bool waitForButton = true;

            while (waitForButton)
            {
                ConsoleKey pusshedKey = Console.ReadKey(true).Key;
                if (pusshedKey == ConsoleKey.UpArrow)
                {
                    ClearCurrentConsoleLine();
                    menuItemIndex++;
                    if (menuItemIndex > 4) menuItemIndex = 0;
                    Console.Write(menuItems[menuItemIndex]);
                }
                if (pusshedKey == ConsoleKey.DownArrow)
                {
                    ClearCurrentConsoleLine();
                    menuItemIndex--;
                    if (menuItemIndex < 0) menuItemIndex = 4;
                    Console.Write(menuItems[menuItemIndex]);
                }

                if (pusshedKey == ConsoleKey.Enter)
                {
                    Console.WriteLine(" ");
                    waitForButton = false;
                }
            }

            switch (menuItemIndex)
            {
                case 0:
                    Console.WriteLine("Task #1. Please, input A then B");
                    Console.WriteLine("Result = " + Summ(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
                    Console.WriteLine("Enter to exit");
                    Console.ReadLine();
                    break;

                case 1:
                    Console.WriteLine("Task #2. Please, input X then Y - coordinates of the point");
                    Console.WriteLine("Position of you point in area - " + PointCoordinates(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
                    Console.WriteLine("Enter to exit");
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("Task #3. Please, input digits to sort");
                    double firstDigit = double.Parse(Console.ReadLine());
                    double secondDigit = double.Parse(Console.ReadLine());
                    double thirdDigit = double.Parse(Console.ReadLine());
                    SortThreeDigits(ref firstDigit, ref secondDigit, ref thirdDigit);
                    Console.WriteLine("Sorted list is - " + firstDigit + ";" + secondDigit + ";" + thirdDigit);
                    Console.WriteLine("Enter to exit");
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("Task #4. Please, input digits A, B, C for quadratic equation");
                    Console.WriteLine("Rots x1 and x2 are - " + QuadraticEquation(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
                    Console.WriteLine("Enter to exit");
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("Task #5. Please, input number from 10 to 99");
                    Console.WriteLine("You've wrote - " + WriteNumber(int.Parse(Console.ReadLine())));
                    Console.WriteLine("Enter to exit");
                    Console.ReadLine();
                    break;

                default:
                    throw new Exception("Something went wrong!");
            }
        }
    }
}
