using System.Collections.Generic;
using System.Text;

namespace _04.GenericSwapMethodIntegers
{
    public class Box<T>
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

        public List<T> SwapMethod(int firstIndex, int secondIndex)
        {

            (Items[firstIndex], Items[secondIndex]) = (Items[secondIndex], Items[firstIndex]);
            return Items;
        }
    }
}