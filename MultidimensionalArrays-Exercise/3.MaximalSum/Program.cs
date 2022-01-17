using System;
using System.Linq;

namespace _3.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[dimensions[0], dimensions[1]];
            int maxSum = int.MinValue;
            int maxRowIndex = -1;
            int maxColIndex = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                int sum = 0;
                for (int cols = 0; cols < matrix.GetLength(1) - 2; cols++)
                {
                    sum = matrix[row, cols] + matrix[row, cols + 1] + matrix[row, cols + 2] +
                           matrix[row + 1, cols] + matrix[row + 1, cols + 1] + matrix[row + 1, cols + 2] +
                           matrix[row + 2, cols] + matrix[row + 2, cols + 1] + matrix[row + 2, cols + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRowIndex = row;
                        maxColIndex = cols;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int row = maxRowIndex; row < maxRowIndex + 3; row++)
            {
                for (int col = maxColIndex; col < maxColIndex + 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
//Create a program that reads a rectangular integer matrix of size N x M
//and finds in it the square 3 x 3 that has a maximal sum of its elements.
//    Input
//    On the first line, you will receive the rows N and columns M.
// On the next N lines, you will receive each row with its columns
//    Output
//        Print the elements of the 3 x 3 square as a matrix, along with their sum