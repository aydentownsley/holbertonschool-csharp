using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> list3 = new List<int>();

        for (int x = 0; x < listLength; x++)
        {
            try
            {
                list3.Add(list1[x] / list2[x]);
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                list3.Add(0);
                continue;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
                continue;
            }  
        }
        return list3;
    }
}
