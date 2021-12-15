using System;
using Windows.Storage;
using Microsoft.Win32;
using System.IO;

namespace Additioonal_HW_Lesson_5
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    class Program
    {
        #region Task1
        private static Point[] GetReadyArrayWithPoints(string filePath)
        {
            int arrSize = 0;

            using (StreamReader streamReader = new StreamReader(filePath))
            {
                while (!streamReader.EndOfStream)
                {
                    streamReader.ReadLine();
                    arrSize++;
                }
            }

            Point[] points = new Point[arrSize];
            int arrPos = 0;

            using (StreamReader streamReader = new StreamReader(filePath))
            {
                while (!streamReader.EndOfStream)
                {
                    string str = streamReader.ReadLine();
                    points[arrPos] = new Point(Convert.ToInt32(str.Split(" ")[0]), Convert.ToInt32(str.Split(" ")[1]));
                    arrPos++;
                }
            }

            return points;
        }

        private static double GetDistanseBetweenPoints(Point a, Point b)
        {
            return Math.Abs(Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2)));
        }

        private static int GetAproxDistance(Point a, Point b)
        {
            return Math.Abs(a.X - b.X + a.Y - b.Y);
        }

        private static (double minDistance, double maxDistance) FindDistanceesFromPlanPoints(Point[] points)
        {
            double min = 0;
            double max = 0;
            int minTemp = GetAproxDistance(points[0], points[1]);
            int maxTemp = minTemp;

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    int insideTemp = GetAproxDistance(points[i], points[j]);
                    if (insideTemp < minTemp)
                    {
                        minTemp = insideTemp;
                        min = GetDistanseBetweenPoints(points[i], points[j]);
                    }
                    else if (insideTemp > maxTemp)
                    {
                        maxTemp = insideTemp;
                        max = GetDistanseBetweenPoints(points[i], points[j]);
                    }
                }
            }

            return (min, max);
        }
        #endregion

        #region Task2
        private static int[,] FillArrayBySpiral_Method_1(int size)
        {
            int[,] arr = new int[size, size];
            int integer = 0;

            for (int j = 0; j < size; j++)
            {
                arr[0, j] = integer++;
            }
            for (int i = 1; i < size; i++)
            {
                arr[i, size - 1] = integer++;
            }
            for (int j = size - 2; j >= 0; j--)
            {
                arr[size - 1, j] = integer++;
            }
            for (int i = size - 2; i > 0; i--)
            {
                arr[i, 0] = integer++;
            }

            int startI = 1;
            int startJ = 1;

            while (integer < size * size)
            {
                while (arr[startI, startJ] == 0)
                {
                    arr[startI, startJ] = integer++;
                    startJ++;
                }
                startJ--;
                startI++;

                while (arr[startI, startJ] == 0)
                {
                    arr[startI, startJ] = integer++;
                    startI++;
                }
                startI--;
                startJ--;

                while (arr[startI, startJ] == 0)
                {
                    arr[startI, startJ] = integer++;
                    startJ--;
                }
                startI--;
                startJ++;

                while (arr[startI, startJ] == 0)
                {
                    arr[startI, startJ] = integer++;
                    startI--;
                }
                startJ++;
                startI++;
            }

            return arr;
        }
        
        private static int[,] FillArrayBySpiral_Method_2(int size)
        {
            int[,] arr = new int[size, size];
            int currentСircle;
            int i;
            int integer = 0;

            for (currentСircle = 1; currentСircle <= size / 2 + size % 2; currentСircle++)
            {
                for (i = currentСircle - 1; i < size - currentСircle + 1; i++)
                {
                    arr[currentСircle - 1, i] = integer++;
                }
                for (i = currentСircle; i < size - currentСircle + 1; i++)
                {
                    arr[i, size - currentСircle] = integer++;
                }
                for (i = size - currentСircle - 1; i >= currentСircle - 1; i--)
                {
                    arr[size - currentСircle, i] = integer++;
                }

                for (i = size - currentСircle - 1; i >= currentСircle; i--)
                {
                    arr[i, currentСircle - 1] = integer++;
                }
            }

            return arr;
        }
        #endregion

        static void Main()
        {

            Point[] points = GetReadyArrayWithPoints(@".\Text Document.txt");
            Console.WriteLine("Minimum distance = " + Math.Round(FindDistanceesFromPlanPoints(points).minDistance, 2)
                + " Maximim distance = " + Math.Round(FindDistanceesFromPlanPoints(points).maxDistance, 2));
            Console.WriteLine();

            int[,] arr = FillArrayBySpiral_Method_2(5);

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
