using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            Func<List<string>, string, string, string, List<string>> checker = (list, douOrRem, criteria, name) =>
            {
                List<string> newList = new List<string>();
                foreach (string str in list)
                {
                    switch (criteria)
                    {
                        case "StartsWith":
                            switch (douOrRem)
                            {
                                case "Double":
                                    if (str.StartsWith(name))
                                    {
                                        newList.Add(str);
                                        newList.Add(str);
                                    }
                                    else
                                    {
                                        newList.Add(str);
                                    }
                                    break;

                                case "Remove":
                                    if (!str.StartsWith(name))
                                    {
                                        newList.Add(str);
                                    }
                                    break;
                            }
                            break;

                        case "Length":
                            switch (douOrRem)
                            {
                                case "Double":
                                    if (str.Length == int.Parse(name))
                                    {
                                        newList.Add(str);
                                        newList.Add(str);
                                    }
                                    else
                                    {
                                        newList.Add(str);
                                    }
                                    break;

                                case "Remove":
                                    if (str.Length != int.Parse(name))
                                    {
                                        newList.Add(str);
                                    }
                                    break;
                            }
                            break;

                        case "EndsWith":
                            switch (douOrRem)
                            {
                                case "Double":
                                    if (str.EndsWith(name))
                                    {
                                        newList.Add(str);
                                        newList.Add(str);
                                    }
                                    else
                                    {
                                        newList.Add(str);
                                    }
                                    break;

                                case "Remove":
                                    if (!str.EndsWith(name))
                                    {
                                        newList.Add(str);
                                    }
                                    break;
                            }
                            break;
                    }
                }
                return newList;
            };

            string[] cmd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (cmd[0] != "Party!")
            {
                names = checker(names, cmd[0], cmd[1], cmd[2]);

                cmd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            if (names.Any())
            {
                Console.WriteLine(string.Join(", ", names) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }

        }
    }
}
//On the first line, you receive a list of all the people that are coming. On the next lines,
//until you get the "Party!" command,
//you may be asked to double or remove all the people that apply to the given criteria.
//There are three different criteria: 
//    Everyone that has his name starting with a given string
//    Everyone that has a name ending with a given string
//    Everyone that has a name with a given length.
//    Finally, print all the guests who are going to the party separated by ", "
// and then add the ending "are going to the party!".
// If no guests are going to the party print "Nobody is going to the party!".