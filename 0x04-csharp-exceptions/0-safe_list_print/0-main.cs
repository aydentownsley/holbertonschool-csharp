using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>() {};
        int count;

        count = List.SafePrint(myList, 1);
        Console.WriteLine("Number of integers printed: " + count);
    }
}
