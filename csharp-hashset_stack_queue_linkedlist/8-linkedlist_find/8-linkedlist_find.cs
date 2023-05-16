using System;
using System.Collections.Generic;

public class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int list = 0;

        foreach (var item in myLList)
        {
            if (item == value)
            return list;
            list++;
        }
        return -1;
    }
}