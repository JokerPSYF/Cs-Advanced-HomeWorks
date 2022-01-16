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
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
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
                stack.Pop();
            }
            while (stack.Count > 0)
            {
                int num = stack.Pop();
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
