using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03.Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        public Stack<T> MyStack { get; set; }

        public CustomStack(Stack<T> stack)
        {
            MyStack = new Stack<T>(stack);
        }

        public void Pop()
        {
            if (this.MyStack.Count == 0)
            {
                Console.WriteLine("No elements");
            }
            else
            {
                Reverse();
                MyStack.Pop();
                Reverse();
            }
        }

        public void Push(T element)
        {
            Reverse();

            MyStack.Push(element);

            Reverse();
        }

        public void Print()
        {
            foreach (T item in MyStack)
            {
                Console.WriteLine(item);
            }

        }

        public void Reverse()
        {
            List<T> stackToList = MyStack.ToList();

            Stack<T> newStack = new Stack<T>(stackToList);

            MyStack = newStack;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in MyStack)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}