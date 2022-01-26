using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace _05.FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int namesCount = int.Parse(Console.ReadLine());
            Dictionary<string, int> ageOfNames = new Dictionary<string, int>();
            for (int i = 0; i < namesCount; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);

                ageOfNames.Add(name, age);
            }

            string condition = Console.ReadLine();
            int ageFormat = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<int, bool> tester = ConditionChecker(condition, ageFormat);

            Dictionary<string, int> newDic = new Dictionary<string, int>();
            foreach (var pair in ageOfNames)
            {

                if (tester(pair.Value))
                {
                    newDic.Add(pair.Key, pair.Value);
                }
            }

            ageOfNames = newDic;

            Action<KeyValuePair<string, int>> printer = ShowNames(format, ageOfNames);

            foreach (var pair in ageOfNames)
            {
                printer.Invoke(pair);
            }
        }

        public static Action<KeyValuePair<string, int>> ShowNames(string format, Dictionary<string, int> dic)
        {
            switch (format)
            {
                case "name age":
                    return dic => Console.WriteLine($"{dic.Key} - {dic.Value}");

                case "name":
                    return dic => Console.WriteLine($"{dic.Key}");

                case "age":
                    return dic => Console.WriteLine($"{dic.Value}");

                default:
                    return null;
            }
        }

        public static Func<int, bool> ConditionChecker(string condition, int ageFormat)
        {
            switch (condition)
            {
                case "older":
                    return x => x >= ageFormat;

                case "younger":
                    return x => x < ageFormat;

                default:
                    return null;
            }
        }
    }
}
//Write a program that receives an integer N on the first line.
//On the next N lines, read pairs of "[name], [age]". Then read three lines:
//    Condition - "younger" or "older"
//    Age - Integer
//    Format - "name", "age" or "name age"