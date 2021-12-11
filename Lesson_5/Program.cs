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

        private static int[] FindMinIndex_3(int[,] arr)
        {
            int[] result = new int[2] { 0, 0 };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[result[0], result[1]] > arr[i, j])
                    {
                        result[0] = i;
                        result[1] = j;
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
                    int up = -1;
                    int right = -1;
                    int down = -1;
                    int left = -1;

                    if (i == 0)
                    {
                        up = 0;
                    }
                    if(j == arr.GetLength(1) - 1)
                    {
                        right = 0;
                    }
                    if (j == 0)
                    {
                        left = 0;
                    }
                    if (i == arr.GetLength(0) - 1)
                    {
                        down = 0;
                    }

                    if(up == -1)
                    {
                        up = arr[i - 1, j];
                    }
                    if(right == -1)
                    {
                        right = arr[i, j + 1];
                    }
                    if (down == -1)
                    {
                        down = arr[i + 1, j];
                    }
                    if (left == -1)
                    {
                        left = arr[i, j - 1];
                    }

                    if(arr[i, j] > (up + right + down + left))
                    {
                        result++;
                    }
                }
            }

            return result;
        }

        private static void Swap(int[,] array, int i, int j)
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
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
            int[] Task3 = FindMinIndex_3(array);
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
