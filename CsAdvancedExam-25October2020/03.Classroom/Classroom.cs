using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;
        public List<Student> Students { get => students; set => students = value; }

        public int Capacity { get; set; }

        public int Count => Students.Count;

        public Classroom(int capacity)
        {
            Students = new List<Student>();
            Capacity = capacity;
        }

        public string RegisterStudent(Student student)
        {
            if (Students.Count < Capacity)
            {
                Students.Add(student);
               return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "No seats in the classroom";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            Student removeHim = Students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

            if (removeHim == null)
            {
                return "Student not found";
            }
            else
            {
                Students.Remove(removeHim);
                return $"Dismissed student {removeHim.FirstName} {removeHim.LastName}";
            }
        }

        public string GetSubjectInfo(string subject)
        {
            Student[] subjectStudent = Students.FindAll(x => x.Subject == subject).ToArray();

            if (subjectStudent.Length == 0)
            {
                return "No students enrolled for the subject";
            }
            else
            {
                StringBuilder builder = new StringBuilder();
                builder.AppendLine($"Subject: {subject}");
                builder.AppendLine($"Students:");

                for (int i = 0; i < subjectStudent.Length; i++)
                {
                    if (i == subjectStudent.Length - 1)
                    {
                        builder.Append($"{subjectStudent[i].FirstName} {subjectStudent[i].LastName}");
                    }
                    else
                    {
                        builder.AppendLine($"{subjectStudent[i].FirstName} {subjectStudent[i].LastName}");
                    }
                }

                return builder.ToString();
            }
        }

        public int GetStudentsCount() => Count;

        public Student GetStudent(string firstName, string lastName)
        => students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

    }
}