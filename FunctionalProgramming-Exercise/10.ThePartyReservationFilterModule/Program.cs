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

            List<string> filteredList = new List<string>();

            for (int i = 0; i < names.Length; i++)
            {
                bool isFiltered = true;
                foreach (var predicate in predicates.Values)
                {
                    if (predicate(names[i]))
                    {
                        isFiltered = false;
                    }
                }

                if (isFiltered)
                {
                    filteredList.Add(names[i]);
                }
            }

            Console.WriteLine(string.Join(" ", filteredList));
        }
    }
}
//You need to implement a filtering module to a party reservation software.
//First, the Party Reservation Filter Module (PRFM for short) is passed a list with invitations.
//Next, the PRFM receives a sequence of commands that specify whether you need to add or remove a given filter.
//    Each PRFM command is in the given format:
//"{command;filter type;filter parameter}"
//You can receive the following PRFM commands: 
//    "Add filter"
//    "Remove filter"
//    "Print"
//The possible PRFM filter types are: 
//    "Starts with"
//    "Ends with"
//    "Length"
//    "Contains"
//All PRFM filter parameters will be a string (or an integer only for the "Length" filter).
//Each command will be valid e.g. you won’t be asked to remove a non-existent filter.
//The input will end with a "Print" command,
//after which you should print all the party-goers that are left after the filtration.