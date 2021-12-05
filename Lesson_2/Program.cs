using System;

namespace Lesson_2
{
    class Program
    {
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
