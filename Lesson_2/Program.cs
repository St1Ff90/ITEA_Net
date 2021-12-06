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

        private static double Sum(double A, double B)
        {
            double result;
            if (A > B)
            {
                result = A + B;
            }
            else if (A == B)
            {
                result = A * B;
            }
            else
            {
                result = A - B;
            }

            return result;
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
                default:
                    return 0;
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
                x1 = 0;
                x2 = 0;
            }
            else
            {
                if (discriminant == 0)
                {
                    x1 = -b / (2 * a);
                    x2 = x1;
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
                switch (num / 10)
                {
                    case 2:
                        result = "twenty ";
                        break;
                    case 3:
                        result = "twenty ";
                        break;
                    case 4:
                        result = "forty ";
                        break;
                    case 5:
                        result = "fifty ";
                        break;
                    case 6:
                        result = "sixty ";
                        break;
                    case 7:
                        result = "seventy ";
                        break;
                    case 8:
                        result = "eighty ";
                        break;
                    case 9:
                        result = "ninety ";
                        break;
                }

                switch (num % 10)
                {
                    case 0:
                        result += string.Empty;
                        break;
                    case 1:
                        result += "one";
                        break;
                    case 2:
                        result += "two";
                        break;
                    case 3:
                        result += "three";
                        break;
                    case 4:
                        result += "four";
                        break;
                    case 5:
                        result += "five";
                        break;
                    case 6:
                        result += "six";
                        break;
                    case 7:
                        result += "seven";
                        break;
                    case 8:
                        result += "eight";
                        break;
                    case 9:
                        result += "nine";
                        break;
                }
            }

            else if (num < 20)
            {
                switch (num)
                {
                    case 10:
                        result = "ten";
                        break;
                    case 11:
                        result = "eleven";
                        break;
                    case 12:
                        result = "twelve";
                        break;
                    case 13:
                        result = "thirteen";
                        break;
                    case 14:
                        result = "fourteen";
                        break;
                    case 15:
                        result = "fifteen";
                        break;
                    case 16:
                        result = "sixteen";
                        break;
                    case 17:
                        result = "seventeen";
                        break;
                    case 18:
                        result = "eighteen";
                        break;
                    case 19:
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
                    Console.WriteLine("Result = " + Sum(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
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
