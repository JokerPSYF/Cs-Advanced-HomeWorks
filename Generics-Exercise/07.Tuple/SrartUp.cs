using System;
using System.Collections.Generic;

namespace _07.Tuple
{
    public class SrartUp
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");

            CustomTuple<string, string> firstTuple = new CustomTuple<string, string>($"{arr[0]} {arr[1]}", arr[2]);

            arr = Console.ReadLine().Split(" ");

            CustomTuple<string, int> secondTuple = new CustomTuple<string, int>(arr[0], int.Parse(arr[1]));

            arr = Console.ReadLine().Split(" ");

            CustomTuple<int, double> thirdTuple = new CustomTuple<int, double>(int.Parse(arr[0]), double.Parse(arr[1]));

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
