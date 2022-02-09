using System;

namespace _08.Threeuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");

            CustomTuple<string, string, string> firstTuple =
                new CustomTuple<string, string, string>(arr[0] + " " + arr[1], arr[2], arr[3]);

            arr = Console.ReadLine().Split(" ");

            bool isDrunk = arr[2] == "drunk" ? true : false;

            CustomTuple<string, int, bool> secondTuple =
                new CustomTuple<string, int, bool>(arr[0], int.Parse(arr[1]), isDrunk);

            arr = Console.ReadLine().Split(" ");

            CustomTuple<string, double, string> thirdTuple =
                new CustomTuple<string, double, string>(arr[0], double.Parse(arr[1]), arr[2]);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
