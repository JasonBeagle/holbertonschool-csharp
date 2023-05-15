using System;
using System.Collections.Generic;

public class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> commonElements = new List<int>();

        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> set2 = new HashSet<int>(list2);

        foreach (int element in set1)
        {
            if (set2.Contains(element))
            {
                commonElements.Add(element);
            }
        }

        commonElements.Sort();

        return commonElements;
    }
}
