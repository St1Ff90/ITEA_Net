using System;
using System.Collections.Generic;

namespace Lesson_3
{
    class Program
    {
        private static double RiseToThePower_1(double num, int degree)
        {
            double result = 1;
            for (int i = 1; i <= degree; i++)
            {
                result *= num;
            }

            return Math.Round(result, 2);
        }

        private static int[] RoundDigits_2(int divider)
        {
            int[] result = new int[1000 / divider];
            int pointer = 0;
            for (int i = divider; i < 1000; i += divider)
            {
                result[pointer++] = i;
            }

            return result;
        }

        private static int TotalCountOfPositiveDigits_3(double maxNum)
        {
            int result = 0;
            for (int i = 1; i <= (int)maxNum; i++)
            {
                if (i * i < maxNum)
                {
                    ++result;
                }
            }

            return result;
        }

        private static int Divider_4(int num)
        {
            int result = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    result = i;
                }
            }

            return result;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static int SumOfDigitsDividedtoSeven_5(int start, int end)
        {
            int result = 0;

            if (end < start)
            {
                Swap(ref start, ref end);
            }

            for (int i = start; i < end; i++)
            {
                if (i % 7 == 0)
                {
                    result += i;
                }
            }

            return result;
        }

        private static int FibonacciLineToStep_6(int count)
        {
            int result = 0;
            int currentNum = 1;
            int previousNum = 1;

            for (int i = 0; i < count - 2; i++)
            {
                result = currentNum + previousNum;
                previousNum = currentNum;
                currentNum = result;
            }

            return result;
        }

        private static int EuclideAlgorithm_7(int first, int second)
        {
            while (first != 0 && second != 0)
            {
                if (first > second)
                {
                    first -= second;
                }
                else
                {
                    second -= first;
                }
            }

            return first + second;
        }


        private static double DigitSqareByBisection_8(int num)
        {
            double left = 0;
            double right = num;
            double result = 0;

            while (right - left > 1.0)
            {
                double middle = (right - left) / 2;
                result = left + middle;
                if (middle * middle * middle < num)
                {
                    left = middle;
                }
                else
                {
                    right = middle;
                }
            }

            return result;
        }


        private static int CountOddNumbers_9(int num)
        {
            int result = 0;

            do
            {
                if (num % 2 == 0)
                {
                    ++result;
                }

                num /= 10;
            } while (num != 0);

            return result;
        }

        private static int ReverseNum_10(int num)
        {
            int result = 0;

            while (num > 0)
            {
                result *= 10;
                result += num % 10;
                num /= 10;
            }

            return result;
        }

        private static int[] NumsWithSumOfEvenBiggerOdd_11(int num)
        {
            int[] result = new int[num / 2];
            int fullNumber = 0;
            int arrayPointer = 0;

            for (int i = 1; i <= num; i++)
            {
                fullNumber = fullNumber * 10 + i;
            }

            for (int i = 0; i < num / 2; i++)
            {
                if (fullNumber % 10 % 2 == 0)
                {
                    result[arrayPointer] = fullNumber;
                    ++arrayPointer;
                }
                fullNumber /= 10;
            }

            return result;
        }

        private static bool SameDigits_12(int first, int second)
        {
            while (first > 0)
            {
                int digitFromFirst = first % 10;
                first /= 10;
                int secondCopy = second;
                while (secondCopy > 0)
                {
                    if (secondCopy % 10 == digitFromFirst)
                    {
                        return true;
                    }

                    secondCopy /= 10;
                }
            }

            return false;
        }


        static void Main(string[] args)
        {
            double Task1Result = RiseToThePower_1(5.2, 12);
            int[] Task2Result = RoundDigits_2(6);
            int Task3Result = TotalCountOfPositiveDigits_3(9.5);
            int Task4Result = Divider_4(61);
            int Task5Result = SumOfDigitsDividedtoSeven_5(1, -15);
            int Task6Result = FibonacciLineToStep_6(10);
            int Task7Result = EuclideAlgorithm_7(1078, 462);
            //double Task8Result = DigitSqareByBisection_8(61);
            int Task9Result = CountOddNumbers_9(87456156);
            int Task10Result = ReverseNum_10(87456156);
            int[] Task11Result = NumsWithSumOfEvenBiggerOdd_11(12);
            bool Task12Result = SameDigits_12(131, 3456789);
        }
    }
}
