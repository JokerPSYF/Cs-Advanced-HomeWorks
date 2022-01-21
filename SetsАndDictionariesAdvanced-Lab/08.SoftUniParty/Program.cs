using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _08.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vip = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();

            string numbers = Console.ReadLine();

            while (numbers != "PARTY")
            {
                if (numbers.Length == 8)
                {
                    if (Char.IsDigit(numbers[0]))
                    {
                        vip.Add(numbers);
                    }
                    else
                    {
                        regular.Add(numbers);
                    }
                }

                numbers = Console.ReadLine();
            }

            numbers = Console.ReadLine();

            while (numbers != "END")
            {
                if (vip.Contains(numbers))
                {
                    vip.Remove(numbers);
                }
                else if (regular.Contains(numbers))
                {
                    regular.Remove(numbers);
                }

                numbers = Console.ReadLine();
            }

            Console.WriteLine(vip.Count + regular.Count);
            if (vip.Any())
            {
                Console.WriteLine(String.Join("\n", vip));

            }
            if (regular.Any())
            {
                Console.WriteLine(String.Join("\n", regular));
            }
        }
    }
}
//There is a party in SoftUni.Many guests are invited and there are two types of them: VIP and Regular.
//When a guest comes, check if he/she exists in any of the two reservation lists.
//    All reservation numbers will be with the length of 8 chars.
//    All VIP numbers start with a digit.
//    First, you will be receiving the reservation numbers of the guests. You can also receive 2 possible commands:
//    "PARTY" – After this command, you will begin receiving the reservation numbers of the people,
// who came to the party.
//    "END" – The party is over and you have to stop the program and print the appropriate output.
//    In the end, print the count of the guests who didn't come to the party,
// and afterward, print their reservation numbers. the VIP guests must be first.