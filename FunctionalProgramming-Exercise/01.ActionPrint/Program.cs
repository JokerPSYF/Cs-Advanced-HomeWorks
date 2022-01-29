using System;

namespace FunctionalProgramming_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            Action<string[]> readArray = names => { Console.WriteLine(string.Join("\n", names)); };

            readArray(names);
        }
    }
}
//Create a program that reads a collection
//of strings from the console and then prints them onto the console.
//Each name should be printed on a new line.Use Action<T>.