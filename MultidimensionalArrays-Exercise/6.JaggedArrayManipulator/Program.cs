using System;
using System.Linq;

namespace _6.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] matrix = new double[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine().Split().Select(double.Parse).ToArray();
                if (i != 0 && matrix[i].Length == matrix[i - 1].Length)
                {
                    matrix[i] = multiply(matrix[i]);
                    matrix[i - 1] = multiply(matrix[i - 1]);
                }
                else if (i != 0 && matrix[i].Length != matrix[i - 1].Length)
                {
                    matrix[i] = devide(matrix[i]);
                    matrix[i - 1] = devide(matrix[i - 1]);
                }
            }

            string[] cmd = Console.ReadLine().Split();

            while (cmd[0] != "End")
            {
                if (cmd[0] == "Add")
                {
                    int row = int.Parse(cmd[1]);
                    int col = int.Parse(cmd[2]);
                    int value = int.Parse(cmd[3]);
                    if (row < matrix.GetLength(0) && row >= 0 && col < matrix[row].Length && col >= 0)
                    {
                        matrix[row][col] += value;
                    }
                }
                else if (cmd[0] == "Subtract")
                {
                    int row = int.Parse(cmd[1]);
                    int col = int.Parse(cmd[2]);
                    int value = int.Parse(cmd[3]);
                    if (row < matrix.GetLength(0) && row >= 0 && col < matrix[row].Length && col >= 0)
                    {
                        matrix[row][col] -= value;
                    }
                }

                cmd = Console.ReadLine().Split();
            }

            ShowMatrix(matrix);
        }

        private static double[] devide(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] /= 2;
            }

            return arr;
        }

        private static double[] multiply(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= 2;
            }

            return arr;
        }

        static void ShowMatrix(double[][] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.WriteLine(string.Join(" ", matrix[row]));
            }

        }
    }
}
//Create a program that populates, analyzes,
//and manipulates the elements of a matrix with an unequal length of its rows.
//    First, you will receive an integer N equal to the number of rows in your matrix.
//    On the next N lines, you will receive sequences of integers,
// separated by a single space. Each sequence is a row in the matrix.
//    After populating the matrix, start analyzing it.
// If a row and the one below it have equal length,
// multiply each element in both of them by 2, otherwise - divide by 2.
//    Then, you will receive commands. There are three possible commands:
//    "Add {row} {column} {value}" - add { value}
//to the element at the given indexes, if they are valid
//    "Subtract {row} {column} {value}" - subtract {value} from the element at the given indexes, if they are valid
//    "End" - print the final state of the matrix (all elements separated by a single space) and stop the program
//Input
//    On the first line, you will receive the number of rows of the matrix - integer N
//    On the next N lines, you will receive each row - sequence of integers, separated by a single space
//    {value} will always be an integer number
//    Then you will be receiving commands until reading "End"
//Output
//    The output should be printed on the console and it should consist of N lines
//    Each line should contain a string representing the respective row of the final matrix,
// elements separated by a single space
//    Constraints
//        The number of rows N of the matrix will be an integer in the range [2 … 12]
//    The input will always follow the format above
//Think about data types