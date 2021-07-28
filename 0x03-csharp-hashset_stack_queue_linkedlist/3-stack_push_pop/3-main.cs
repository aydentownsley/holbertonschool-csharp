using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        Stack<string> aStack = new Stack<string>();

        foreach (string item in aStack)
            Console.WriteLine(item);

        Console.WriteLine("------");

        MyStack.Info(aStack, "C#", "C++");

        Console.WriteLine("------");

        foreach (string item in aStack)
            Console.WriteLine(item);
    }
}
