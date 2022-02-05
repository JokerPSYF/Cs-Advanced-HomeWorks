using System;
using System.Text;

namespace CreateCustomDataStructures
{
    public class CustomList<T>
    {
        private const int constCapacity = 2;

        private T[] items;

        public int Count { get; private set; }

        public int indexer { get; set; }

        public CustomList()
        {
            items = new T[constCapacity];
        }

        public T this[int index]
        {
            get
            {
                if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return items[index];
            }
            set
            {
                if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                items[index] = value;   
            }
        }

        private void Resize()
        {
            T[] newArr = new T[items.Length * 2];

            for (int i = 0; i < items.Length; i++)
            {
                newArr[i] = items[i];
            }

            items = newArr;
        }

        public void Add(T element)
        {
            if (Count == items.Length)
            {
                Resize();
            }

            items[Count] = element;
            Count++;
        }

        private void Shift(int index)
        {
            for (int i = index; i < Count -1; i++)
            {
                items[i] = items[i + 1];
            }
        }

        private void Shrink()
        {
            T[] newArr = new T[items.Length / 2];

            for (int i = 0; i < Count; i++)
            {
                newArr[i] = items[i];
            }

            items = newArr;
        }

        public T RemoveAt(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            T removeThat = items[index];
            items[index] = default(T);
            Shift(index);
            Count--;
            if (Count <= items.Length / 4)
            {
                Shrink();
            }

            return removeThat;
        }

        private void ShiftToRight(int index)
        {
            for (int i = Count; i > index; i--)
            {
                items[i] = items[i - 1];
            }
        }

        public void Insert(int index, T element)
        {
            if (index > Count)
            {
                throw new IndexOutOfRangeException();
            }

            if (Count == items.Length)
            {
                Resize();
            }

            ShiftToRight(index);

            items[index] = element;
            Count++;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < Count; i++)
            {
               if (items[i].Equals(element)) return true;
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T temp = items[firstIndex];

            items[firstIndex] = items[secondIndex];

            items[secondIndex] = temp;
        }

        public int Find(T element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(element))
                {
                    return i;
                }
            }
            throw new InvalidOperationException($"Theres no {element} in {items}");
        }

        public void Reverse()
        {
            T[] newArr = new T[items.Length];
            for (int i = 0; i < Count; i++)
            {
                newArr[i] = items[Count - i];
            }

            items = newArr;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Count; i++)
            {
                if (i % 5 == 0)
                {
                    sb.AppendLine(items[i].ToString());
                }
                else
                {
                    sb.Append(items[i].ToString() + " ");
                }
            }
            return sb.ToString();
        }
    }
}