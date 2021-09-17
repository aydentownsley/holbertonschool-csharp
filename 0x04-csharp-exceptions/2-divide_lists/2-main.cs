using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> list1 = new List<int>() {10, 2};
        List<int> list2 = new List<int>() {};
        List<int> result;

        result = List.Divide(list1, list2, 2);

        foreach (int i in result)
            Console.WriteLine(i);
    }
}
