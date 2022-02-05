using System;
using System.Text;

namespace CreateCustomDataStructures
{
    public class CustomList
    {
        private const int constCapacity = 2;

        private int[] items;

        public int Count { get; private set; }

        public int indexer { get; set; }

        public CustomList()
        {
            items = new int[constCapacity];
        }

        public int this[int index]
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
            int[] newArr = new int[items.Length * 2];

            for (int i = 0; i < items.Length; i++)
            {
                newArr[i] = items[i];
            }

            items = newArr;
        }

        public void Add(int element)
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
            int[] newArr = new int[items.Length / 2];

            for (int i = 0; i < Count; i++)
            {
                newArr[i] = items[i];
            }

            items = newArr;
        }

        public int RemoveAt(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int removeThat = items[index];
            items[index] = default(int);
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

        public void Insert(int index, int element)
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

        public bool Contains(int element)
        {
            for (int i = 0; i < Count; i++)
            {
               if (items[i] == element) return true;
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            int temp = items[firstIndex];

            items[firstIndex] = items[secondIndex];

            items[secondIndex] = temp;
        }

        public int Find(int element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i] == element)
                {
                    return i;
                }
            }
            throw new InvalidOperationException($"Theres no {element} in {items}");
        }

        public void Reverse()
        {
            int[] newArr = new int[items.Length];
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