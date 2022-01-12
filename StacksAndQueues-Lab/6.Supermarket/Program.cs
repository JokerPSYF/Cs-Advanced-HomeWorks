using System;
using System.Collections.Generic;

namespace _6.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var clients = new Queue<string>();
            while (input != "End")
            {
                if (input == "Paid")
                {
                    while (clients.Count > 0)
                    {
                        Console.WriteLine(clients.Dequeue());
                    }
                }
                else
                {
                    clients.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{clients.Count} people remaining.");
        }
    }
}
