using System;

public class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] NewArray = new int[size];

        for (int i = 0; i < size; i++)
        {
            NewArray[i] = i;
            if (i < size -1)
                Console.Write(NewArray[i] + " ");
            else
                Console.Write(NewArray[i]);
        }
        Console.WriteLine();
        return NewArray;
    }
}