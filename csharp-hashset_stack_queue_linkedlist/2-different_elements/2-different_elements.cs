using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> uniqElem = new List<int>();

        foreach (int element in list1)
        {
            if (!list2.Contains(element))
            {
                uniqElem.Add(element);
            }
        }

        foreach (int element in list2)
        {
            if (!list1.Contains(element))
            {
                uniqElem.Add(element);
            }
        }
        uniqElem.Sort();

        return uniqElem;
    }
}
