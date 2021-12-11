using System;

namespace Lesson_5
{
    class Program
    {
        private static int FindMixElement_1 (int[,] arr)
        {
            int result = arr[0,0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if(result > arr[i, j])
                    {
                        result = arr[i, j];
                    }
                }
            }

            return result;
        }



        static void Main(string[] args)
        {
            int[,] array = new int[5,5];
            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = random.Next(-10, 100);
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }

            int Task1 = FindMixElement_1(array);
        }
    }
}
