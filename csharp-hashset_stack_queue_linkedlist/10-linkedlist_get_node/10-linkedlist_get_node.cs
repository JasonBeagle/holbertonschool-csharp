using System;
using System.Collections.Generic;

public class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int ind = 0;
        foreach (var elem in myLList)
        {
            if (ind == n)
            return elem;
            ind++;
        }
        return 0;
    }
}