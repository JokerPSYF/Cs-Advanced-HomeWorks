using System;
using System.Collections.Generic;

namespace _8.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            var cars = new Queue<string>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            count++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
