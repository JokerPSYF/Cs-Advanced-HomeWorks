using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Predicate<string>> predicates = new Dictionary<string, Predicate<string>>();

            string[] names = Console.ReadLine().Split();

            string[] cmd = Console.ReadLine().Split(";");

            //Predicate<string> 

            while (cmd[0] != "Print")
            {
                string command = cmd[0];
                string filterType = cmd[1];
                string filterParameter = cmd[2];

                if (cmd[0] == "Add filter")
                {
                    switch (cmd[1])
                    {
                        case "Starts with":
                            Predicate<string> predicate = name => { return name.StartsWith(filterParameter); };
                            predicates.Add($"{filterType}{filterParameter}", predicate);
                            break;

                        case "Ends with":
                            Predicate<string> predicate1 = name => { return name.EndsWith(filterParameter); };
                            predicates.Add($"{filterType}{filterParameter}", predicate1);
                            break;

                        case "Length":
                            Predicate<string> predicate2 = name => { return name.Length == int.Parse(filterParameter); };
                            predicates.Add($"{filterType}{filterParameter}", predicate2);
                            break;

                        case "Contains":
                            Predicate<string> predicate3 = name => { return name.Contains(filterParameter); };
                            predicates.Add($"{filterType}{filterParameter}", predicate3);
                            break;
                    }
                }
                else
                {
                    predicates.Remove($"{filterType}{filterParameter}");
                }

                cmd = Console.ReadLine().Split(";");
            }

            for (int i = 0; i < names.Length; i++)
            {
                foreach (var predicate in predicates.Values)
                {
                    if (predicate(names[i]))
                    {
                        names[i] = string.Empty;
                    }
                }
            }


            Console.WriteLine(string.Join(" ", names));
        }
    }
}
