using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(arr);
            int num;
            while (queue.Count > 1)
            {
                num = queue.Dequeue();
                if (num % 2 == 0)
                {
                    Console.Write($"{num}, ");
                }
            }
            num = queue.Peek();
            if (num % 2 == 0)
            {
                Console.Write(num);
            }
        }
    }
}
