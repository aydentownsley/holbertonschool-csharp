using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        int sum = 0;
        List<int> newList = new List<int>();
        newList = myList.Distinct().ToList();
        foreach (int x in newList)
            sum += x;
        return sum;
    }
}
