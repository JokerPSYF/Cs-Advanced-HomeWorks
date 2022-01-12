using System;
using System.Collections.Generic;

namespace _7.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            var kids = new Queue<string>(Console.ReadLine().Split());
            int tossed = int.Parse(Console.ReadLine());
            int count = 1;
            while (kids.Count > 1)
            {
                string potatoKid = kids.Dequeue();
                if (tossed == count)
                {
                    count = 1;
                    Console.WriteLine($"Removed {potatoKid}");
                }
                else
                {
                    kids.Enqueue(potatoKid);
                    count++;
                }
            }
            Console.WriteLine($"Last is {kids.Peek()}");
        }
    }
}
