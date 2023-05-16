using System;
using System.Collections.Generic;

public class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> tempList = new LinkedList<int>();

        if (size < 0)
        {
            return tempList;
        }

        for (int i = 0; i < size; i++)
        {
            tempList.AddLast(i);
        }
        foreach (int item in tempList)
        {
            Console.WriteLine(item);
        }
        return tempList;
    }
}