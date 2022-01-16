using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int capacity = int.Parse(Console.ReadLine());
            int sum = 0;
            int racks = 1;
            while (stack.Count > 0)
            {
                int cloth = stack.Pop();
                if (sum + cloth == capacity && stack.Count > 0)
                {
                    racks++;
                    sum = 0;
                }
                else if (sum + cloth > capacity)
                {
                    racks++;
                    sum = cloth;
                }
                else
                {
                    sum += cloth;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
