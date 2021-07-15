using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);
        LinkedListNode<int> current = myLList.First;
        for (int x = 0; x < myLList.Count; x++)
        {
            if (n < current.Next.Value)
            {
                myLList.AddAfter(current, newNode);
                return newNode;
            }
            else
                current = current.Next;
        }
        return newNode;
    }
}
