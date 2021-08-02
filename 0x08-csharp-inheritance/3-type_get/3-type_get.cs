using System;

class Obj
{
    /// <summary>
    /// Prints Properties and Methods of obj type.
    /// </summary>
    /// <param name="obj">Input Object.</param>
    public static void Print(object myObj)
    {
        Console.WriteLine("{0} Properties:", myObj.GetType().Name);
        foreach (var prop in myObj.GetType().GetProperties())
            Console.WriteLine(prop.Name);
        Console.WriteLine("{0} Methods:", myObj.GetType().Name);
        foreach (var method in myObj.GetType().GetMethods())
            Console.WriteLine(method.Name);
    }
}
