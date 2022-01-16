using System;
using System.Linq;
using System;
using System.Linq;

namespace _1.SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lenght = Console.ReadLine().Split(", ", StringSplitOptions.None).Select(int.Parse).ToArray();
            int[,] matrix = new int[lenght[0], lenght[1]];
            int sum = 0;
            for (int row = 0; row < lenght[0]; row++)
            {
                int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < lenght[1]; col++)
                {
                    matrix[row, col] = line[col];
                    sum += line[col];
                }
            }
            Console.WriteLine(lenght[0]);
            Console.WriteLine(lenght[1]);
            Console.WriteLine(sum);
        }
    }
}
//Write a program that reads a matrix from the console and prints:
//Count of rows
//Count of columns
//Sum of all matrix elements
//On the first line, you will get matrix sizes in format [rows, columns] 