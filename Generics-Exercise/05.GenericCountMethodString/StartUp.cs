﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.GenericCountMethodString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                list.Add(input);
            }

            Box<string> box = new Box<string>(list);

            string compare = Console.ReadLine();

            int count = box.CountMethod(compare);

            Console.WriteLine(count);
        }
    }
}
