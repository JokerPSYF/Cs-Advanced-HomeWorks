﻿namespace ClassroomProject
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Subject { get; set; }

        public Student(string firstName, string lastName, string subject)
        {
            FirstName = firstName;

            LastName = lastName;

            Subject = subject;
        }

        public override string ToString()
            => $"Student: First Name = {FirstName}, Last Name = {LastName}, Subject = {Subject}";
       
    }
}