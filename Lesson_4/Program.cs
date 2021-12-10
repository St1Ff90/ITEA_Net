﻿using System;

namespace Lesson_4
{
    class Program
    {

        private static int MinNumInArray_1(int[] arr)
        {
            int result = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < result)
                {
                    result = arr[i];
                }
            }

            return result;
        }

        private static int MaxNumInArray_2(int[] arr)
        {
            int result = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > result)
                {
                    result = arr[i];
                }
            }

            return result;
        }

        private static int MinIndexInArray_3(int[] arr)
        {
            int currentValue = int.MaxValue;
            int result = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < currentValue)
                {
                    currentValue = arr[i];
                    result = i;
                }
            }

            return result;
        }

        private static int MaxIndexInArray_4(int[] arr)
        {
            int currentValue = int.MinValue;
            int result = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > currentValue)
                {
                    currentValue = arr[i];
                    result = i;
                }
            }

            return result;
        }

        private static int SummOfOddItemsInArray_5(int[] arr)
        {
            int result = 0;

            for (int i = 1; i < arr.Length; i += 2)
            {
                result += arr[i];
            }

            return result;
        }

        private static void ReverseArray_6(ref int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }
        }

        private static int OddEleemeentsCount_7(int[] arr)
        {
            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    result++;
                }
            }

            return result;
        }

        private static void ReverseNums_8(ref int[] arr)
        {
            int integerPlus = 1;

            if (arr.Length % 2 == 0)
            {
                integerPlus = 0;
            }

            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length / 2 + i + integerPlus];
                arr[arr.Length / 2 + i + integerPlus] = temp;
            }
        }


        private static void SelectionSortIncrease_9(ref int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                int j = i + 1;
                for (; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }

        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        private static void InsertSortDecrease_10(ref int[] arr)
        {
            int x;
            int j;

            for (int i = 1; i < arr.Length; i++)
            {
                x = arr[i];
                j = i;
                while (j > 0 && arr[j - 1] < x)
                {
                    Swap(arr, j, j - 1);
                    j -= 1;
                }
                arr[j] = x;
            }
        }

        private static string[] MatchesToStringSearch(string str, string toFind)
        {
            int arraySize = 1;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    arraySize++;
                }
            }

            string[] result = new string[arraySize];

            int arrayPlace = 0;
            while (arrayPlace < arraySize)
            {
                if(str.Contains(" "))
                {
                    string cutted = str.Substring(0, str.IndexOf(' '));
                    str = str.Substring(cutted.Length + 1);
                    if (cutted.Contains(toFind))
                    {
                        result[arrayPlace] = cutted;
                        arrayPlace++;
                    }
                }
                else if(str.Length > 0)
                {
                    if (str.Contains(toFind))
                    {
                        result[arrayPlace] = str;
                        str = str.Substring(str.Length);
                    }
                }
                else
                {
                    break;
                }
            }

            return result;
        }

        static void Main()
        {

            int[] array = new int[5];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 100);
                Console.Write(array[i] + " ");
            }

            int Task1 = MinNumInArray_1(array);
            int Tasl2 = MaxNumInArray_2(array);
            int Tasl3 = MinIndexInArray_3(array);
            int Tasl4 = MaxIndexInArray_4(array);
            int Tasl5 = SummOfOddItemsInArray_5(array);
            ReverseArray_6(ref array);
            int Tasl7 = OddEleemeentsCount_7(array);
            ReverseNums_8(ref array);
            SelectionSortIncrease_9(ref array);
            InsertSortDecrease_10(ref array);
            string[] search = MatchesToStringSearch("You are my dear friend", "e");

        }
    }
}
