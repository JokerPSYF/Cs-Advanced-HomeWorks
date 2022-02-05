using System;
using System.Security.Cryptography.X509Certificates;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {
        private class ListNode
        {
            public int Value { get; set; }
            public ListNode PreviousNode { get; set; }
            public ListNode NextNode { get; set; }

            public ListNode(int value)
            {
                this.Value = value;
            }
        }

        private ListNode head;

        private ListNode tail;

        public int Count { get; private set; }

        public void AddFirst(int element)
        {
            if (this.Count == 0)
            {
                this.head = tail = new ListNode(element);
            }
            else
            {
                ListNode newHead = new ListNode(element);

                newHead.NextNode = head;
                head.PreviousNode = newHead;
                head = newHead;
            }

            Count++;
        }

        public void AddLast(int element)
        {
            if (Count == 0)
            {
                head = tail = new ListNode(element);
            }
            else
            {
                ListNode newTail = new ListNode(element);

                newTail.PreviousNode = tail;
                tail.NextNode = newTail;
                tail = newTail;
            }

            Count++;
        }

        public int RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            else if (Count == 1)
            {
                var removeThat = head;
                head = tail = null;
                Count--;
                return removeThat.Value;
            }
            else
            {
                var removeThat = head;
                head = head.NextNode;
                head.PreviousNode = null;
                Count--;
                return removeThat.Value;
            }
        }

        public int RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            else if (Count == 1)
            {
                var removeThat = tail;
                head = tail = null;
                Count--;
                return removeThat.Value;
            }
            else
            {
                var removeThat = tail;
                tail = tail.PreviousNode;
                tail.NextNode = null;
                Count--;
                return removeThat.Value;
            }
        }

        public void ForEach(Action<int> action)
        {
            ListNode currentNode = head;

            while (currentNode != null )
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[Count];
            ListNode curreNode = head; 
            for (int i = 0; i < Count; i++)
            {
                array[i] = curreNode.Value;
                curreNode = curreNode.NextNode;
            }

            return array;
        }
    }
}