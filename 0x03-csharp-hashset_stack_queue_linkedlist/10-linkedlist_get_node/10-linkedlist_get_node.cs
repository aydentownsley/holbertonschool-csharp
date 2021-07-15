using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int count = 0;
        if (myLList.Count == 0)
            return 0;
        else if (n > myLList.Count)
            return 0;
        foreach (int item in myLList)
        {
            if (count == n)
                return item;
            count++;
        }
        return 0;
    }
}
