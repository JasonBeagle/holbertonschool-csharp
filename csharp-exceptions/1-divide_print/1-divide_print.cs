using System;

public class Int
{
    public static void divide(int a, int b)
    {
        int divid = 0;
        try
        {
            divid = a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, divid);
        }
    }
}