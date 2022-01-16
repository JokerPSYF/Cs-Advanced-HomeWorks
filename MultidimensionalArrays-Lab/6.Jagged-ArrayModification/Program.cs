using System;
using System.Collections.Immutable;
using System.Linq;

namespace _6.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jaggedMatrix = new int[n][];
            for (int row = 0; row < n; row++)
            {
                //jaggedMatrix[row] = new int[n];
                jaggedMatrix[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            string[] cmd = Console.ReadLine().Split(); 
            while (cmd[0] != "END")
            {
                int r = int.Parse(cmd[1]);
                int c = int.Parse(cmd[2]);
                int value = int.Parse(cmd[3]);
                switch (cmd[0])
                {
                    case "Add":
                        if (r >= 0 && c >= 0 && r < jaggedMatrix.GetLength(0) && c < jaggedMatrix.GetLength(0))
                        {
                            jaggedMatrix[r][c] += value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;
                    case "Subtract":
                        if (r >= 0 && c >= 0 && r < jaggedMatrix.GetLength(0) && c < jaggedMatrix.GetLength(0))
                        {
                            jaggedMatrix[r][c] -= value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;
                }
                cmd = Console.ReadLine().Split();
            }

            for (int rows = 0; rows < jaggedMatrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < jaggedMatrix.GetLength(0); cols++)
                {
                    Console.Write(jaggedMatrix[rows][cols] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
//Create a program that reads a matrix from the console.
//On the first line, you will get matrix rows. On the next
//rows lines, you will get elements for each column separated
//with space. You will be receiving commands in the following format:
//Add {row} {col} {value} – Increase the number at the given coordinates with the value.
//    Subtract {row} { col}
//{ value} – Decrease the number at the given coordinates by the value.
//    Coordinates might be invalid. In this case, you should print
// "Invalid coordinates". When you receive "END" you should print the matrix and stop the program.