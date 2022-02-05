using System;

namespace CreateCustomDataStructures
{
    public class CustomQueue<T>
    {
        private const int initialCapacity = 4;

        private const int firstElementIndex = 0;

        private T[] items;

        private int count;

        public int Count { get => count; private set => count = value; }

        public CustomQueue()
        {
            count = 0;
            items = new T[initialCapacity];
        }

        public void Enqueue(T element)
        {
            if (Count == 0) throw new ArgumentOutOfRangeException("The queue is empty");

            if (Count == items.Length) Resize();

            ShiftToRight();
            items[firstElementIndex] = element;
            count++;
        }

        public T Dequeue()
        {
            if (Count == 0) throw new ArgumentOutOfRangeException("The queue is empty");

            if (Count <= items.Length / 4) Shrink();

            T removeThat = items[firstElementIndex];
            ShiftToLeft();
            count--;
            return removeThat;
        }

        public T Peek()
        {
            if (Count == 0) throw new ArgumentOutOfRangeException("The queue is empty");

            return items[firstElementIndex];
        }

        public void Clear()
        {
            if (Count == 0) throw new ArgumentOutOfRangeException("The queue is already empty");

            items = new T[initialCapacity];
        }

        private void ShiftToRight()
        {
            for (int i = Count; i > 0; i--)
            {
                items[i] = items[i - 1];
            }
        }

        private void ShiftToLeft()
        {
            for (int i = 0; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }

            items[Count] = default;
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