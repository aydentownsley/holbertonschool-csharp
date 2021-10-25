using System;

class Queue<T>
{
    /// <summary>
    /// Returns the Queue's Type
    /// </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    public class Node
    {
        public T value;
        public Node next;

        public Node(T value)
        {
            this.value = value;
        }
    }

    Node head;
    Node tail;
    private int count = 0;

    public Node Enqueue(T value)
    {
        Node node = new Node(value);
        if (count == 0)
        {
            head = node;
            tail = head;
        }
        else
        {

            while (tail.next != null)
                tail = tail.next;
            tail.next = node;
        }
        this.count++;
        return node;
    }

    public T Dequeue()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            Node node = head;
            head = head.next;
            this.count--;
            return node.value;
        }
    }

    public int Count()
    {
        return count;
    }
}
