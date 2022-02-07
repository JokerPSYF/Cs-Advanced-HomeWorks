using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.GenericCountMethodDouble
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<double> list = new List<double>();

            for (int i = 0; i < lines; i++)
            {
                double input = double.Parse(Console.ReadLine());
                list.Add(input);
            }

            Box<double> box = new Box<double>(list);

            double compare = double.Parse(Console.ReadLine());

            int count = box.CountMethod(compare);

            Console.WriteLine(count);
        }
    }
}
