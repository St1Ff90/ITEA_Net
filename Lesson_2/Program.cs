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
            if (A > B) return A + B;
            if (A == B) return A * B;
            if (A < B) return A - B;
            throw new Exception("Something went wrong!");
        }

        private static string PointCoordinates(double x, double y)
        {
            switch (true)
            {
                case true when x < 0 && y < 0:
                    return "Left/Down";
                case true when x < 0 && y > 0:
                    return "Right/Down";
                case true when x > 0 && y < 0:
                    return "Left/Up";
                case true when x < 0 && y > 0:
                    return "Right/Up";
                default:
                    throw new Exception("Something went wrong!");
            }
        }
         

        private static void SortThreeDigits(ref double first, ref double second, ref double third)
        {
            double buffer;
            if (first > second)
            {
                buffer = second;
                second = first;
                first = buffer;
            }
            if (second > third)
            {
                buffer = third;
                third = second;
                second = buffer;
            }
            if (first > second)
            {
                buffer = second;
                second = first;
                first = buffer;
            }
        }

        private static (double x1, double x2) QuadraticEquation(double a, double b, double c)
        {
            double x1, x2;
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0) throw new Exception("Equation has NO roots");
            else
            {
                if (discriminant == 0) x1 = x2 = -b / (2 * a);
                else
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                }
                return (x1, x2);
            }
        }

        private static string WriteNumber(int num)
        {
            string result = null;

            Dictionary<int, string> dictinary = new Dictionary<int, string>
            {
                { 0, "" },
                { 1, "one" },
                { 2, "two" },
                { 3, "three" },
                { 4, "four" },
                { 5, "five" },
                { 6, "six" },
                { 7, "seven" },
                { 8, "eight" },
                { 9, "nine" },
                { 20, "twenty " },
                { 30, "thirty " },
                { 40, "forty " },
                { 50, "fifty " },
                { 60, "sixty " },
                { 70, "seventy " },
                { 80, "eighty " },
                { 90, "ninety " }
            };

            if (num == 10) result = "ten";
            if (num == 11) result = "eleven";
            if (num == 12) result = "twelve";
            if (num == 13) result = "thirteen";
            if (num == 15) result = "fifteen";
            if (num - 10 >= 6 && num - 10 <= 9 || num == 14) result = dictinary[num % 10] + "teen";
            if (num >= 20 && num <= 99) result = dictinary[num / 10 * 10] + dictinary[num % 10];

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
