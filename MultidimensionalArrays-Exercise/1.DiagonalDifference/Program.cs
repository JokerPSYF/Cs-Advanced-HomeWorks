using System;
using System.Linq;

namespace _1.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];
            int leftToRight = 0;
            int rightToLeft = 0;
            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    arr[row, col] = input[col];
                }
            }
            for (int i = 0; i < n; i++)
            {
                leftToRight += arr[i, i];
                rightToLeft += arr[i, arr.GetLength(0) - 1 - i];
            }
            Console.WriteLine(Math.Abs(leftToRight - rightToLeft));
        }
    }
}
//Create a program that finds the difference between the sums of the square matrix diagonals (absolute value).
//Input
//    On the first line, you are given the integer N – the size of the square matrix
//    The next N lines hold the values for every row – N numbers separated by a space
//Output
//    Print the absolute difference between the sums of the primary and the secondary diagonal