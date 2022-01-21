using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> usernames = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                usernames.Add(Console.ReadLine());
            }

            Console.WriteLine(string.Join("\n", usernames));
        }
    }
}
//Create a program that reads from the console a sequence of N
//usernames and keeps a collection only of the unique ones. On the first line,
//you will be given an integer N. On the next N lines, you will receive one username per line.