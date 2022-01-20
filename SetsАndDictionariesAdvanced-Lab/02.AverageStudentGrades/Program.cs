using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentsRecords = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] grade = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (!studentsRecords.ContainsKey(grade[0]))
                {
                    studentsRecords.Add(grade[0], new List<decimal>());
                    studentsRecords[grade[0]].Add(decimal.Parse(grade[1]));
                }
                else
                {
                    studentsRecords[grade[0]].Add(decimal.Parse(grade[1]));
                }
            }

            foreach (var student in studentsRecords)
            {
                Console.Write($"{student.Key} -> ");
                foreach (decimal grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {student.Value.Average(x => x):f2})");
            }
        }
    }
}
//Create a program, which reads a name of a student and his/her grades and adds them to the student record,
//then prints the students' names with their grades and their average grade.