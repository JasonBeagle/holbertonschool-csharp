using System;
using System.Collections.Generic;

public class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> uniqueIntegers = new HashSet<int>();

        foreach (int number in myList)
        {
            if (!uniqueIntegers.Contains(number))
            {
                uniqueIntegers.Add(number);
            }
        }

        int sum = 0;
        foreach (int uniqueNumber in uniqueIntegers)
        {
            sum += uniqueNumber;
        }

        return sum;
    }
}
