using System;
using System.Collections.Generic;
using _02.GenericBoxOfInteger;

namespace _02.GenericBoxOfInteger
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Box<int>> listofBoxes = new List<Box<int>>();

            for (int i = 0; i < lines; i++)
            {
                int input = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(input);

                listofBoxes.Add(box);
            }

            foreach (Box<int> box in listofBoxes)
            {
                Console.WriteLine(box);
            }
        }
    }
}