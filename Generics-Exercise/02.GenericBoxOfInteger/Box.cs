using System.Text;

namespace _02.GenericBoxOfInteger
{
    public class Box<T>
    {
        public T Item { get; set; }

        public Box(T item)
        {
            Item = item;
        }

        public override string ToString()
        {
            return $"{typeof(T)}: {this.Item}";
        }
    }
}