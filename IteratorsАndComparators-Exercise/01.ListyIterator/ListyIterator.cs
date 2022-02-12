using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace _01.ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        public List<T> CollectionList { get; set; }

        public int Index { get; set; }

        public ListyIterator(List<T> list)
        {
            CollectionList = new List<T>(list);

            Index = 0;
        }

        public bool Move()
        {
            if (HasNext())
            {
                Index++;
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (CollectionList.Count > 0)
            {
                Console.WriteLine(CollectionList[Index]);
            }
            else
            {
                Console.WriteLine("Invalid Operation!");
            }

        }

        public bool HasNext() => Index + 1 < CollectionList.Count;

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in CollectionList)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
      
    }
}