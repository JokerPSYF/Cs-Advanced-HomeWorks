using System;
using System.Linq;

namespace _3.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int sum = 0;
            int[,] matrix = new int[rows, rows];
            for (int row = 0; row < rows; row++)
            {
                int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < rows; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                sum += matrix[i , i];
            }
            Console.WriteLine(sum);
        }
    }
}
//Create a program that finds the sum of matrix primary diagonal.
//On the first line, you are given the integer N – the size of the square matrix
//The next N lines hold the values for every row – N numbers separated by a space