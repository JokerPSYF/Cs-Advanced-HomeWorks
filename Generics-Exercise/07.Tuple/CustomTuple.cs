using System.Text;

namespace _07.Tuple
{
    public class CustomTuple<T, T2>
    {
        public T Item1 { get; set; }

        public T2 Item2 { get; set; }

        public CustomTuple(T item1, T2 item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        public override string ToString()
                 => $"{Item1} -> {Item2}";
    }
}