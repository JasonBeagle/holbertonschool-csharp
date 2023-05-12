using System;

public class FizzBuzz
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write("FizzBuzz ");
                continue;
            }
            if (i % 3 == 0)
            {
                Console.Write("Fizz ");
                continue;
            }
            if (i % 5 == 0)
            {
                Console.Write("Buzz ");
                continue;
            }
            Console.Write(i + " ");
        }
    }
}
