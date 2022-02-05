using System;

namespace CustomDoublyLinkedList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList node = new DoublyLinkedList();
            for (int i = 1; i <= 5; i++)
            {
                node.AddFirst(i);
            }

            node.ForEach(n => Console.Write(n + " "));

            int lastNum = node.RemoveLast();
            Console.WriteLine(lastNum);

            node.ForEach(n => Console.Write(n + " "));

            Console.WriteLine();

            int[] arr = node.ToArray();

            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
