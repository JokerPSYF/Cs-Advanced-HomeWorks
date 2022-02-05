using System;
using System.Collections.Generic;
using System.Text;

namespace CreateCustomDataStructures
{
    class CustomStack
    {
        private const int initialCapacity = 4;

        private int[] items;

        private int count;

        public int Count { get => count; private set => count = value; }

        public CustomStack()
        {
            Count = 0;

            items = new int[initialCapacity];
        }

        public void Push(int element)
        {
            if (items.Length == Count)
            {
                Resize();
            }

            items[Count] = element;
            Count++;
        }

        public int Pop()
        {
            if (Count == 0)
            {
                throw new ArgumentOutOfRangeException("The stack is empty");
            }
            int removeThat = items[Count - 1];
            items[Count - 1] = default(int);
            Count--;

            if (Count <= items.Length / 4)
            {
                Shrink();
            }

            return removeThat;
        }

        public int Peek()
        {
            if (Count == 0 )
            {
                throw new ArgumentOutOfRangeException("The stack is empty");
            }

            int giveMeThat = items[Count - 1];
            return giveMeThat;
        }

        public void ForEach(Action<object> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(items[i]);
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

        private void Shrink()
        {
            int[] newArr = new int[items.Length / 2];

            for (int i = 0; i < Count; i++)
            {
                newArr[i] = items[i];
            }

            items = newArr;
        }
    }
}
