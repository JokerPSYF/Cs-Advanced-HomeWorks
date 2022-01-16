using System;
using System.Collections.Generic;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> playlist = new Queue<string>(Console.ReadLine().Split(", "));
            while (playlist.Count > 0)
            {
                string input = Console.ReadLine();
                if (input.StartsWith("Add"))
                {
                    string song = input.Substring(4);
                    if (!playlist.Contains(song))
                    {
                        playlist.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (input.StartsWith("Show"))
                {
                    Console.WriteLine(string.Join(", ",playlist));
                }
                else if (input.StartsWith("Play"))
                {
                    playlist.Dequeue();
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
