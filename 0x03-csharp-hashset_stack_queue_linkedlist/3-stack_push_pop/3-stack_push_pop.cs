﻿using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of itmes: {0}", aStack.Count);
        Console.WriteLine("Top item: {0}", aStack.Peek());
        Console.WriteLine("Stack contains \"{0}\": {1}", search, aStack.Contains(search));
        if (aStack.Contains(search))
        {
            while (aStack.Peek() != search)
                aStack.Pop();
            aStack.Pop();
        }
        aStack.Push(newItem);
        return aStack;
    }
}
