using System;

namespace _4.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            char special = Char.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i,j] == special)
                    {
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{special} does not occur in the matrix");
        }
    }
}
//Create a program that reads N, a number representing rows and cols of a matrix.
//On the next N lines, you will receive rows of th matrix. Each row consists of 
//ASCII characters. After that, you will receive a symbol. Find the
//first occurrence of that symbol in the matrix and print its
//position in the format: "({row}, {col})".If there is no such symbol print an error message 
//"{symbol} does not occur in the matrix "