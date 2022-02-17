using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            //queue thread
            // stack task    
            Stack<int> tasks = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Queue<int> threads = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int killThatTask = int.Parse(Console.ReadLine());

            int thread = default;

            while (true)
            {
                int task = tasks.Peek();
                thread = threads.Peek();

                if (task == killThatTask)
                {
                    break;
                }

                if (thread >= task)
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
                else threads.Dequeue();
            }

            Console.WriteLine($"Thread with value {thread} killed task {killThatTask}");
            Console.WriteLine(string.Join(" ", threads));

        }
    }
}
