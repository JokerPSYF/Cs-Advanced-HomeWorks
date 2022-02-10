using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }

        public int Year { get; set; }

        public IReadOnlyList<string> Authors { get; set; }

        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors.ToList();
        }

        public override string ToString() => $"{Title} - {Year}";

        public int CompareTo(Book other)
         => Year.CompareTo(other.Year) == 0 ? Title.CompareTo(other.Title) : Year.CompareTo(other.Year);
    }
}