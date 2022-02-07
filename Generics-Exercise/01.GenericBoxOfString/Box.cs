using System.Text;

namespace _01.GenericBoxOfString
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