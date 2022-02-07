using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.GenericCountMethodString
{
    public class Box<T>
    where T : IComparable
    {
        public List<T> Items { get; set; }

        public Box(List<T> item)
        {
            Items = item;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T item in Items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString();
        }

        public int CountMethod(T compare)
        {
            return Items.Count(x=> x.CompareTo(compare) > 0);
        }
    }
}