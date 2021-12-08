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

        private static int[] RoundDigits_2(int devider)
        {
            int[] result = new int[1000];
            int pointer = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % devider == 0)
                {
                    result[pointer] = i;
                    ++pointer;
                }
            }

            return result;
        }

        private static int TotalCountOfPositiveDigits_3(double maxNum)
        {
            int result = 0;
            for (int i = 1; i <= (int)Math.Sqrt(maxNum); i++)
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

        private static int SunOfDigitsDividedtoSeven_5(int start, int end)
        {
            int result = 0;

            if (end > start)
            {
                for (int i = start; i < end; i++)
                {
                    if (i % 7 == 0)
                    {
                        result += i;
                    }
                }
            }
            else
            {
                for (int i = start; i > end; i--)
                {
                    if (i % 7 == 0)
                    {
                        result += i;
                    }
                }
            }

            return result;
        }

        private static int FibonacciLineToStep_6(int count)
        {
            int result = 0;
            int currentNum = 1;
            int previousNum = 1;
            int i = 0;

            if (count == 1 || count == 2) return 1;
            else if (count > 2)
            {
                while (i < count - 2)
                {
                    result = currentNum + previousNum;
                    previousNum = currentNum;
                    currentNum = result;
                    ++i;
                }
            }
            else
            {
                currentNum = -1;
                previousNum = -1;
                while (i > count + 2)
                {
                    result = previousNum + currentNum;
                    currentNum = previousNum;
                    previousNum = result;
                    --i;
                }
            }

            return result;
        }

        private static int EuclideAlgorithm_7(int first, int second)
        {
            int result = 0;

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

            if (first != 0)
            {
                result = first;
            }
            else
            {
                result = second;
            }

            return result;
        }


        private static double DigitSqareByBisection_8(int num) // не работает 
        {
            double left = 0;
            double right = num;
            double result = 0;

            while (right - left*left > 1.0)
            {
                result = (right - left) / 2;
                double middle = left + result;
                if (result * result * result > num)
                {
                    left = result;
                }
                else
                {
                    right = result;
                }
            }

            return result;
        }


        private static int CountOddNumbers_9(int num)
        {
            int result = 0;

            do
            {
                if (num % 10 % 2 == 0)
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
            int[] result = new int[num/2+1];
            int fullNumber = 0;
            int arrayPointer = 0;

            for (int i = 1; i <= num; i++)
            {
                fullNumber = fullNumber * 10 + i;
            }

            for (int i = 0; i < num; i++)
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
                    if(secondCopy % 10 == digitFromFirst)
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
            int[] Task2Result = RoundDigits_2(68);
            int Task3Result = TotalCountOfPositiveDigits_3(9.5);
            int Task4Result = Divider_4(96);
            int Task5Result = SunOfDigitsDividedtoSeven_5(1, -15);
            int Task6Result = FibonacciLineToStep_6(-10);
            int Task7Result = EuclideAlgorithm_7(1078, 462);
            double Task8Result = DigitSqareByBisection_8(27);
            int Task9Result = CountOddNumbers_9(87456156);
            int Task10Result = ReverseNum_10(87456156);
            int[] Task11Result = NumsWithSumOfEvenBiggerOdd_11(7);
            bool Task12Result = SameDigits_12(131, 3456789);
        }
    }
}
