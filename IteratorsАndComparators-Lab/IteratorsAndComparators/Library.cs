using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();


        private class LibraryIterator : IEnumerator<Book>
        {
            private int currentIndex;

            private readonly List<Book> books;

            public LibraryIterator(List<Book> books)
            {
                books.Sort(new BookComparator());
                currentIndex = -1;
                this.books = new List<Book>(books);
            }

            public bool MoveNext() => ++currentIndex < books.Count;


            public void Reset() { }


            public Book Current => books[currentIndex];

            object IEnumerator.Current => Current;

            public void Dispose() { }
        }
    }
}