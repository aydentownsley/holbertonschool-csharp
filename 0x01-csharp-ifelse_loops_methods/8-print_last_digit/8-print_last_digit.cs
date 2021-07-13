using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        if (number < 0)
            number = number * -1;
        Console.Write("{0}", number % 10);
        return number % 10;
    }
}
