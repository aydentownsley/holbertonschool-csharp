using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);
        LinkedListNode<int> current = myLList.First;
        while (current.Next != null)
        {
            if (n < current.Value)
            {
                myLList.AddBefore(current, newNode);
                return newNode;
            }
            else if (n < current.Next.Value)
            {
                myLList.AddAfter(current, newNode);
                return newNode;
            }
            else
                current = current.Next;
        }
        if (current.Value < n)
        {
            myLList.AddAfter(current, newNode);
            return newNode;
        }
        else
        {
            myLList.AddBefore(current, newNode);
            return newNode;
        }
    }
}
