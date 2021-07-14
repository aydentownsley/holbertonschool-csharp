using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> keys = new List<string>();
        keys = myDict.Keys.ToList();
        keys.Sort();
        foreach (string key in keys)
        {
            Console.WriteLine("{0}: {1}", key, myDict[key]);
        }
    }
}
