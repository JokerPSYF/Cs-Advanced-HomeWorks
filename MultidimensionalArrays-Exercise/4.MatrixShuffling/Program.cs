using System;
using System.Linq;

namespace _4.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[dimensions[0], dimensions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string[] cmd = Console.ReadLine().Split();

            while (cmd[0] != "END")
            {
                if (cmd.Length == 5 && IsRange(matrix, int.Parse(cmd[1]), int.Parse(cmd[2]))
                                    && IsRange(matrix, int.Parse(cmd[3]), int.Parse(cmd[4]))
                                    && cmd[0] == "swap")
                {
                    int row1 = int.Parse(cmd[1]);
                    int row2 = int.Parse(cmd[3]);
                    int col1 = int.Parse(cmd[2]);
                    int col2 = int.Parse(cmd[4]);
                    string temp = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = temp;

                    ShowMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                cmd = Console.ReadLine().Split();
            }

        }

        private static void ShowMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        static bool IsRange(string[,] matrix, int row, int col)
        {
            bool isTrue = row < matrix.GetLength(0) && col < matrix.GetLength(1)
                                                && row >= 0 && col >= 0;
            return isTrue;
        }
    }
}
//Write a program that reads a string matrix from the console and performs certain operations with its elements.
//User input is provided in a similar way as in the problems above – first, you read the dimensions and then the data. 
//    Your program should then receive commands in the format: "swap row1 col1 row2 col2"
// where row1, col1, row2, col2 are coordinates in the matrix. For a command to be valid,
// it should start with the "swap" keyword along with four valid coordinates (no more, no less).
// You should swap the values at the given coordinates (cell [row1, col1] with cell[row2, col2])
// and print the matrix at each step (thus you'll be able to check if the operation was performed correctly). 
//If the command is not valid (doesn't contain the keyword "swap",
//has fewer or more coordinates entered or the given coordinates do not exist),
//print "Invalid input!" and move on to the next command.
//Your program should finish when the string "END" is entered.