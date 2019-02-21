using System;

namespace LinkedListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class LinkedList
    {
        Node first;
        Node last;

        public class Node
        {
            public object data;
            public Node next;
        }

        public void AddToList(object _value)
        {
            Node node = new Node();
            node.data = _value;

            if (first == null)
            {
                first = node;
                last = node;
            }
            else
            {
                last.next = node;
                last = node;
            }
        }

        public object getNthFromLast(int n)
        {
            if (n < 0)
                n = Math.Abs(n);

            int length = 0;
            Node temp = first;

            while (temp != null)
            {
                temp = temp.next;
                length++;
            }

            if (length < n)
                return null;

            temp = first;

            for (int i = 1; i < length - n + 1; i++)
                temp = temp.next;

            return temp.data;
        }
    }
}
