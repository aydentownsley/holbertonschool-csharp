using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);
        LinkedListNode<int> current = myLList.First;
        
        while (current != null)
        {
            if (current.Value > n)
            {
                myLList.AddBefore(current, newNode);
                return newNode;
            }
            else if (current.Value < n)
            {
                if (current.Next == null)
                {
                    myLList.AddAfter(current, newNode);
                    return newNode;
                }
                current = current.Next;
            }
        }
        myLList.AddFirst(newNode);
        return newNode;
    }
}
