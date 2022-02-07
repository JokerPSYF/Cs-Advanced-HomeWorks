using System;
using System.Collections.Generic;

namespace _01.GenericBoxOfString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Box<string>> listofBoxes = new List<Box<string>>();

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                Box<string> box = new Box<string>(input);

                listofBoxes.Add(box);
            }

            foreach (Box<string> box in listofBoxes)
            {
                Console.WriteLine(box);
            }
        }
    }
}
