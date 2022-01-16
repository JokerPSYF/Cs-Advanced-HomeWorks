using System;
using System.Linq;

namespace _5.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lenght = Console.ReadLine().Split(", ", StringSplitOptions.None).Select(int.Parse).ToArray();
            int[,] matrix = new int[lenght[0], lenght[1]];
            int[,] bestSquare = new int[2, 2];
            int maxSum = Int32.MinValue;
            for (int row = 0; row < lenght[0]; row++)
            {
                int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < lenght[1]; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0) -1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = 0;
                    if (row + 2 <= lenght[0] && col + 2 <= lenght[1])
                    {
                        sum = matrix[row, col] +
                              matrix[row, col + 1] +
                              matrix[row + 1, col] +
                              matrix[row + 1, col + 1];
                    }

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        bestSquare = new int[,]
                        {
                            { matrix[row, col], matrix[row, col + 1] },
                            {matrix[row + 1, col], matrix[row + 1, col + 1] }
                        };
                    }
                }
            }

            Console.WriteLine($"{bestSquare[0,0]} {bestSquare[0,1]}");
            Console.WriteLine($"{bestSquare[1,0]} {bestSquare[1,1]}");
            Console.WriteLine(maxSum);
        }
    }
}
//Create a program that reads a matrix from the console. Then find the
//biggest sum of the 2x2 submatrix and print it to the console.
//On the first line, you will get matrix sizes in format rows, columns.
//In the lines of One next row, you will get elements for each column separated with a comma.
//Print the biggest top-left square, which you find, and the sum of its elements.