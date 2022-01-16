using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> queue = new Queue<int[]>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                int[] pump = new int[3];

                pump[0] = int.Parse(input[0]);
                pump[1] = int.Parse(input[1]);
                pump[2] = i;

                queue.Enqueue(pump);
            }
            int petrol = 0;
            int index = -1;
            int[] info;
            for (int i = 0; i < n; i++)
            {
                info = queue.Dequeue();
                if (index < 0)
                {
                    index = info[2];
                }
                petrol += info[0];
                int km = info[1];
                petrol -= km;
                if (petrol < 0)
                {
                    i = -1;
                    petrol = 0;
                    index = -1;
                }
                queue.Enqueue(info);
            }
            Console.WriteLine(index);
        }
    }
}