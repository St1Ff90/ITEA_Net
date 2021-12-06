using System;
using System.Collections.Generic;

namespace ITEA_Net
{
    class Program
    {
        public static double Task1(double A, double B)
        {
            return (5 * A + B * B) / (B - A);
        }
        public static (string A, string B) Task2(string _first, string _second)
        {
            (string, string) tuple = (_second, _first);
            return tuple;
        }

        public static (int resultOfDividing, int chengeFromDividing) Task3(int A, int B)
        {
            (int, int) tuple = (A / B, A % B);
            return tuple;
        }

        public static double Task4(double A, double B, double C)
        {
            return (C - B) / A;
        }

        public static (double A, double B) Task5(double X1, double Y1, double X2, double Y2)
        {
            (double, double) tuple = ((Y2 - Y1) / (X2 - X1), (X1 * Y2 - X2 * Y1) / (X2 - X1) * -1);
            return tuple;
        }

        static void Main(string[] args)
        {
            Console.Write("Please, enter a number of the task (from 1 to 5): ");
            string numberOfTask = Console.ReadLine();
            int i = 0;
            if (!int.TryParse(numberOfTask, out i))
            {
                Console.WriteLine("Use only digits!");
                Console.ReadLine();
                return;
            }
            if (i < 1 || i > 5)
            {
                Console.WriteLine("From 1 to 5!");
                Console.ReadLine();
                return;
            }
            else
            {
                switch (i)
                {
                    case 1:
                        double A1, B1; //digits from the user
                        Console.Write("Please, enter A (\",\" is allowed)= ");
                        if (!double.TryParse(Console.ReadLine(), out A1))
                        {
                            Console.WriteLine("Use only digits!"); // Error messege
                            Console.ReadLine();
                            return;
                        }
                        Console.Write("Please, enter B (\",\" is allowed)= ");
                        if (!double.TryParse(Console.ReadLine(), out B1))
                        {
                            Console.WriteLine("Use only digits!");
                            Console.ReadLine();
                            return;
                        }
                        double resultTast1 = Math.Round(Task1(A1, B1), 2); //result of the calculation
                        Console.WriteLine("Result of calculation: " + resultTast1);
                        break;

                    case 2:
                        Console.Write("Please, enter first string ");
                        string first = Console.ReadLine();
                        Console.Write("Please, enter second string ");
                        string second = Console.ReadLine();
                        (string A, string B) tuple = Task2(first, second);
                        first = tuple.A;
                        Console.WriteLine("Result if the first string: " + first);
                        second = tuple.B;
                        Console.WriteLine("Result if the second string: " + second);
                        break;

                    case 3:
                        int A3, B3; //digits from the user
                        Console.Write("Please, enter integer A= ");
                        try
                        {
                            A3 = int.Parse(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.ReadLine();
                            return;
                        }
                        Console.Write("Please, enter integer B= ");
                        try
                        {
                            B3 = int.Parse(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.ReadLine();
                            return;
                        }
                        Console.WriteLine("Result of dividing= " + Task3(A3, B3).resultOfDividing);
                        Console.WriteLine("Chenge from dividing= " + Task3(A3, B3).chengeFromDividing);
                        break;

                    case 4:
                        double A4, B4, C4; //digits from the user
                        Console.Write("Please, enter A (\",\" is allowed, 0 isn't allowed)= ");
                        if (!double.TryParse(Console.ReadLine(), out A4) || A4 == 0)
                        {
                            Console.WriteLine("Use only digits!"); // Error messege
                            if (A4 == 0) Console.WriteLine("Can't be 0!"); //Zero check
                            Console.ReadLine();
                            return;
                        }

                        Console.Write("Please, enter B (\",\" is allowed)= ");
                        if (!double.TryParse(Console.ReadLine(), out B4))
                        {
                            Console.WriteLine("Use only digits!");
                            Console.ReadLine();
                            return;
                        }
                        Console.Write("Please, enter С (\",\" is allowed)= ");
                        if (!double.TryParse(Console.ReadLine(), out C4))
                        {
                            Console.WriteLine("Use only digits!");
                            Console.ReadLine();
                            return;
                        }
                        double resultTast4 = Math.Round(Task4(A4, B4, C4), 2); //result of the calculation
                        Console.WriteLine("Result of calculation: " + resultTast4);
                        break;

                    case 5:
                        double X1, Y1, X2, Y2; //digits from the user
                        Console.Write("Please, enter X1 (\",\" is allowed)= ");
                        if (!double.TryParse(Console.ReadLine(), out X1))
                        {
                            Console.WriteLine("Use only digits!"); // Error messege
                            Console.ReadLine();
                            return;
                        }

                        Console.Write("Please, enter Y1 (\",\" is allowed)= ");
                        if (!double.TryParse(Console.ReadLine(), out Y1))
                        {
                            Console.WriteLine("Use only digits!"); // Error messege
                            Console.ReadLine();
                            return;
                        }

                        Console.Write("Please, enter X2 (\",\" is allowed)= ");
                        if (!double.TryParse(Console.ReadLine(), out X2))
                        {
                            Console.WriteLine("Use only digits!"); // Error messege
                            Console.ReadLine();
                            return;
                        }

                        Console.Write("Please, enter Y2 (\",\" is allowed)= ");
                        if (!double.TryParse(Console.ReadLine(), out Y2))
                        {
                            Console.WriteLine("Use only digits!"); // Error messege
                            Console.ReadLine();
                            return;
                        }

                        if (X1 == X2 && Y1 == Y2)
                        {
                            Console.WriteLine("Two points have the same value!"); // Error messege
                            Console.ReadLine();
                            return;
                        }

                        if (Task5(X1, Y1, X2, Y2).B >= 0) Console.WriteLine("Final result is:  Y=" + Math.Round(Task5(X1, Y1, X2, Y2).A, 2) + "X+" + Math.Round(Task5(X1, Y1, X2, Y2).B), 2);
                        else Console.WriteLine("Final result is:  Y=" + Math.Round(Task5(X1, Y1, X2, Y2).A, 2) + "X" + Math.Round(Task5(X1, Y1, X2, Y2).B), 2);
                        break;




                    default:
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}