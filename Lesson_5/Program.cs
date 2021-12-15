using System;

namespace Lesson_5
{
    class Program
    {
        private static int FindMinElement_1(int[,] arr)
        {
            int result = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (result > arr[i, j])
                    {
                        result = arr[i, j];
                    }
                }
            }

            return result;
        }

        private static int FindMaxElement_2(int[,] arr)
        {
            int result = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (result < arr[i, j])
                    {
                        result = arr[i, j];
                    }
                }
            }

            return result;
        }

        private static (int i, int j) FindMinIndex_3(int[,] arr)
        {
            (int i, int j) result = (0, 0);

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[result.i, result.j] > arr[i, j])
                    {
                        result.i = i;
                        result.j = j;
                    }
                }
            }

            return result;
        }

        private static int[] FindMaxIndex_4(int[,] arr)
        {
            int[] result = new int[2] { 0, 0 };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[result[0], result[1]] < arr[i, j])
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }

            return result;
        }

        private static int CompaneNeighbors_5(int[,] arr)
        {
            int result = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i > 0 && arr[i, j] < arr[i - 1, j])
                    {
                        continue;
                    }
                    if (i < arr.GetLength(0) - 1 && arr[i, j] < arr[i + 1, j])
                    {
                        continue;
                    }
                    if (j > 0 && arr[i, j] < arr[i, j - 1])
                    {
                        continue;
                    }
                    if (j < arr.GetLength(1) - 1 && arr[i, j] < arr[i, j + 1])
                    {
                        continue;
                    }

                    result++;
                }
            }

            return result;
        }

        private static void Swap(int[,] array, int i, int j)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }

        private static void MirrorArray_6(ref int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j > i)
                    {
                        Swap(arr, i, j);
                    }
                }
            }
        }



        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-10, 100);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            int Task1 = FindMinElement_1(array);
            int Task2 = FindMaxElement_2(array);
            (int i, int j) Task3 = FindMinIndex_3(array);
            int[] Task4 = FindMaxIndex_4(array);
            int Task5 = CompaneNeighbors_5(array);
            MirrorArray_6(ref array);
            Console.WriteLine();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
