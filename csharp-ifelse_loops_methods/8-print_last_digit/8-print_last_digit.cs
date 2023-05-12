using System;

public class Number
{
    public static int PrintLastDigit(int number)
    {
        int last_diggy = Math.Abs(number % 10);
        Console.Write(last_diggy);
        return last_diggy;
    }
}
