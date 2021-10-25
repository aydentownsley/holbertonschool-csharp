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

    /// <summary>
    /// defines feature of queue
    /// </summary>
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

    /// <summary>
    /// adds value to queue at tail.
    /// </summary>
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

    /// <summary>
    /// Removes head and returns value of head
    /// </summary>
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

    /// <summary>
    /// Return value of head without removing head
    /// </summary>
    public T Peek()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            return head.value;
        }
    }

    /// <summary>
    /// prints contents of queue
    /// </summary>
    public void Print()
    {
        if (count == 0)
            Console.WriteLine("Queue is empty");
        else
        {
            Node temp = head;
            while (temp.next != null)
            {
                Console.WriteLine(temp.value);
                temp = temp.next;
            }
            Console.WriteLine(temp.value);
        }

    }

    /// <summary>
    /// combines values of all queue nodes into a string and prints
    /// </summary>
    public string Concatenate()
    {
        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }
        else if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        else
        {
            Node temp = head;
            String contents = null;
            if (typeof(T) == typeof(string))
            {
                while (temp.next != null)
                {
                    contents = contents + temp.value + " ";
                    temp = temp.next;
                }
                contents = contents + temp.value;
                return contents;
            }
            else
            {
                while (temp.next != null)
                {
                    contents = contents + temp.value;
                    temp = temp.next;
                }
                contents = contents + temp.value;
                return contents;
            }
        }
    }

    /// <summary>
    /// return length of queue
    /// </summary>
    public int Count()
    {
        return count;
    }
}
