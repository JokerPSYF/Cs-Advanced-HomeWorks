using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowAndCol = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[rowAndCol[0], rowAndCol[1]];

            string input = Console.ReadLine();

            List<string> plantedFlowers = new List<string>();

            while (input != "Bloom Bloom Plow")
            {
                plantedFlowers.Add(input);

                rowAndCol = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (IsInRange(matrix, rowAndCol[0], rowAndCol[1])) matrix[rowAndCol[0], rowAndCol[1]]++;
                else Console.WriteLine("Invalid coordinates.");

                input = Console.ReadLine();
            }

            foreach (string flower in plantedFlowers)
            {
                rowAndCol = flower
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                PlowUp(ref matrix, rowAndCol[0], rowAndCol[1]);
                PlowRight(ref matrix, rowAndCol[0], rowAndCol[1]);
                PlowDown(ref matrix, rowAndCol[0], rowAndCol[1]);
                PlowLeft(ref matrix, rowAndCol[0], rowAndCol[1]);
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        static bool IsInRange(int[,] matrix, int row, int col)
            => row >= 0 && row < matrix.GetLength(0)
                        && col >= 0 && col < matrix.GetLength(1);

        static void PlowUp(ref int[,] matrix, int row, int col)
        {

            //Up
            while (IsInRange(matrix, row - 1, col))
            {
                matrix[row - 1, col]++;
                row--;
            }
        }

        static void PlowRight(ref int[,] matrix, int row, int col)
        {
            //Right
            while (IsInRange(matrix, row, col + 1))
            {
                matrix[row, col + 1]++;
                col++;
            }
        }

        static void PlowDown(ref int[,] matrix, int row, int col)
        {
            //Down
            while (IsInRange(matrix, row + 1, col))
            {
                matrix[row + 1, col]++;
                row++;
            }
        }

        static void PlowLeft(ref int[,] matrix, int row, int col)
        {
            //Left
            while (IsInRange(matrix, row, col - 1))
            {
                matrix[row, col - 1]++;
                col--;
            }
        }
    }
}

