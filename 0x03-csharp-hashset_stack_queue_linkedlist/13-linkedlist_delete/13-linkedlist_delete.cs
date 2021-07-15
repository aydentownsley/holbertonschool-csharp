using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> current = myLList.First;
        int count = 0;
        while (current != null)
        {
            if (count == index)
                myLList.Remove(current);
            current = current.Next;
            count++;    
        }
    }
}
