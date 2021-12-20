using System;
using System.Collections.Generic;

namespace Lesson_4
{
    class Program
    {

        private static int MinNumInArray_1(int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Array is empty");
            }

            return arr[MinIndexInArray_3(arr)];
        }

        private static int MaxNumInArray_2(int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Array is empty");
            }

            return arr[MaxIndexInArray_4(arr)];

        }

        private static int MinIndexInArray_3(int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Array is empty");
            }

            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arr[result])
                {
                    result = i;
                }
            }

            return result;
        }

        private static int MaxIndexInArray_4(int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Array is empty");
            }

            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr[result])
                {
                    result = i;
                }
            }

            return result;
        }

        private static int SummOfOddItemsInArray_5(int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Array is empty");
            }

            int result = 0;

            for (int i = 1; i < arr.Length; i += 2)
            {
                result += arr[i];
            }

            return result;
        }

        private static void ReverseArray_6(ref int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Array is empty");
            }

            if (arr.Length < 1)
            {
                throw new ArgumentException("Nothing to reverse");
            }

            for (int i = 0; i < arr.Length / 2; i++)
            {
                Swap(arr, i, arr.Length - i - 1);
            }
        }

        private static int OddEleemeentsCount_7(int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Array is empty");
            }

            if (arr.Length < 1)
            {
                throw new ArgumentException("Nothing to count");
            }

            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    result++;
                }
            }

            return result;
        }

        private static void ReverseNums_8(ref int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Array is empty");
            }

            if (arr.Length < 1)
            {
                throw new ArgumentException("Nothing to reverse");
            }

            int integerPlus = arr.Length % 2;

            for (int i = 0; i < arr.Length / 2; i++)
            {
                Swap(arr, i, arr.Length / 2 + i + integerPlus);
            }
        }


        private static void SelectionSortIncrease_9(ref int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Array is empty");
            }

            if (arr.Length < 1)
            {
                throw new ArgumentException("Nothing to sort");
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                Swap(arr, i, min);
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
            if (arr == null)
            {
                throw new ArgumentNullException("Array is empty");
            }

            if (arr.Length < 1)
            {
                throw new ArgumentException("Nothing to sort");
            }

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
            if(string.IsNullOrEmpty(str) || string.IsNullOrEmpty(toFind))
            {
                throw new ArgumentException("Shouldn't be empty");
            }

            int arraySize = 0;
            int startPossition = 0;

            while (true)
            {
                if (str.IndexOf(" ", startPossition) != -1)
                {
                    string cutted = str.Substring(startPossition, str.IndexOf(" ", startPossition)-startPossition);
                    startPossition += cutted.Length+1;
                    if(cutted.Contains(toFind))
                    {
                        arraySize++;
                    }
                }
                else
                {
                    string cutted = str.Substring(startPossition);
                    if (cutted.Contains(toFind))
                    {
                        arraySize++;
                    }
                    break;
                }
            }

            string[] result = new string[arraySize];

            int arrayPlace = 0;
            while (arrayPlace < arraySize && str.Length > 0)
            {
                if (str.Contains(" "))
                {
                    string cutted = str.Substring(0, str.IndexOf(' '));
                    str = str.Substring(cutted.Length + 1);
                    if (cutted.Contains(toFind))
                    {
                        result[arrayPlace++] = cutted;
                    }
                }
                else
                {
                    if (str.Contains(toFind))
                    {
                        result[arrayPlace] = str;
                    }
                    break;
                }
            }

            return result;
        }

        static void Main()
        {
            try
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
                string[] search = MatchesToStringSearch("Hello a eddd! red ffr ", "e");

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            
        }
    }
}
