using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ListyIterator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .ToList();

            ListyIterator<string> collection = new ListyIterator<string>(items);

            string cmd = Console.ReadLine();

            try
            {
                while (cmd != "END")
                {
                    switch (cmd)
                    {
                        case "Move":
                            Console.WriteLine(collection.Move());
                            break;

                        case "Print":
                            collection.Print();
                            break;

                        case "HasNext":
                            Console.WriteLine(collection.HasNext());
                            break;

                        case "PrintAll":
                            Console.WriteLine(string.Join(" ", collection));
                            break;
                    }

                    cmd = Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}