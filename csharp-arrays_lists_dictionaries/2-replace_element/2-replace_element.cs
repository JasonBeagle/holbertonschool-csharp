using System;

public class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (index > array.Length || index < 0)
        {
            Console.WriteLine("Index out of range");
            return array;
        }
        int[] NewArray = array;
        for (int i = 0; i < NewArray.Length; i++)
        {
            if (index == i)
            {
                NewArray[i] = n;
            }
        }
        return NewArray;
    }
}