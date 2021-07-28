using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
            return "None";
        string name = "";
        int score = myList.Values.Max();
        foreach (var key in myList)
        {
            if (key.Value == score)
                name = key.Key;
        }
        return name;
    }
}
