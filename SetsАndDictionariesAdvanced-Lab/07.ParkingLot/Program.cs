using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> register = new HashSet<string>();
            string[] cmd = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            while (cmd[0] != "END")
            {
                if (cmd[0] == "IN")
                {
                    register.Add(cmd[1]);
                }
                else if (cmd[0] == "OUT" && register.Contains(cmd[1]))
                {
                    register.Remove(cmd[1]);
                }

                cmd = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            if (register.Any())
            {
                Console.WriteLine(string.Join("\n", register));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
//Create a program that:
//    Records a car number for every car that enters the parking lot
//    Removes a car number when the car leaves the parking lot
//    The input will be a string in the format: "direction, carNumber".
//    You will be receiving commands until the "END" command is given.