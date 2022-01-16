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
            for (int row = 0; row < lenght[0]; row++)
            {
                int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < lenght[1]; col++)
                {
                    matrix[row, col] = line[col];
                }
            }
            for (int col = 0; col < lenght[1]; col++)
            {
                int sum = 0;
                for (int row = 0; row < lenght[0]; row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
//Create a program that reads a matrix from the console and prints the sum for each column. On the first line, you will get matrix rows. On the next rows lines, you will get elements for each column separated with a space. 
//Read matrix sizes.
//On the next row, lines read the columns.
//Traverse the matrix and sum all elements in each column.
//Print the sum and continue with the other columns.