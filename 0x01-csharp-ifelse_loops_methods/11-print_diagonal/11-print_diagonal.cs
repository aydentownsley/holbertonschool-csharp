using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        int spaces;
        int count;

        if (length > 0)
        {
            for (count = 0; count < length; count++)
            {
                for (spaces = 0; spaces < count; spaces++)
                    Console.Write(" ");
                Console.WriteLine("\\ ");
            }
        }
        else
            Console.WriteLine();
        Console.WriteLine();
    }
}
