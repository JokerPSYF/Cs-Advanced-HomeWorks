using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> stack = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int toPush = input[0];
            int toPop = input[1];
            int specialNum = input[2];
            int smallestNum = int.MaxValue;
            if (toPop >= toPush)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < toPop; i++)
            {
                stack.Dequeue();
            }
            while (stack.Count > 0)
            {
                int num = stack.Dequeue();
                if (num == specialNum)
                {
                    Console.WriteLine("true");
                    return;
                }
                if (smallestNum >= num) smallestNum = num;
            }
            Console.WriteLine(smallestNum);
        }
    }
}
