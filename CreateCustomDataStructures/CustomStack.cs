using System;
using System.Collections.Generic;
using System.Text;

namespace CreateCustomDataStructures
{
    class CustomStack<T>
    {
        private const int initialCapacity = 4;

        private T[] items;

        private int count;

        public int Count { get => count; private set => count = value; }

        public CustomStack()
        {
            Count = 0;

            items = new T[initialCapacity];
        }

        public void Push(T element)
        {
            if (items.Length == Count)
            {
                Resize();
            }

            items[Count] = element;
            Count++;
        }

        public T Pop()
        {
            if (Count == 0)
            {
                throw new ArgumentOutOfRangeException("The stack is empty");
            }
            T removeThat = items[Count - 1];
            items[Count - 1] = default(T);
            Count--;

            if (Count <= items.Length / 4)
            {
                Shrink();
            }

            return removeThat;
        }

        public T Peek()
        {
            if (Count == 0 )
            {
                throw new ArgumentOutOfRangeException("The stack is empty");
            }

            T giveMeThat = items[Count - 1];
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
            T[] newArr = new T[items.Length * 2];

            for (int i = 0; i < items.Length; i++)
            {
                newArr[i] = items[i];
            }

            items = newArr;
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
    }
}
