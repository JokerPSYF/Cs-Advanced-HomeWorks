using System;
using System.Linq;
using System.Threading.Channels;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string cmd = Console.ReadLine();

            Func<int[], int[]> add = arr =>
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i]++;
                }
                return arr;
            };
            
            Func<int[], int[]> multiply = arr =>
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] *= 2;
                }
                return arr;
            };

            Func<int[], int[]> subtract = arr =>
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i]--;
                }
                return arr;
            };

            Action<int[]> print = arr => Console.WriteLine(string.Join(" ", arr));



            while (cmd != "end")
            {
                switch (cmd)
                {
                    case "multiply":
                        multiply(nums);
                        break;

                    case "add":
                        add(nums);
                        break;

                    case "subtract":
                        subtract(nums);
                        break;

                    case "print":
                        print(nums);
                        break;
                }

                cmd = Console.ReadLine();
            }
        }
    }
}
//Create a program that executes some mathematical operations on a given collection.
//On the first line, you are given a list of numbers.
//On the next lines you are passed different commands that you need to apply to all the numbers in the list:
//    "add"->add 1 to each number
//    "multiply" -> multiply each number by 2
//    "subtract" -> subtract 1 from each number
//    "print" -> print the collection
//    "end" -> ends the input 