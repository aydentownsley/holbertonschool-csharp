using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        myList.Sort();
        return myList[myList.Count - 1];
    }
}
