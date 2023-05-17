using System;
using System.Collections.Generic;

public class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int printMe = 0;

        try
        {
            while (printMe < n)
            {
                Console.WriteLine(myList[printMe]);
                printMe++;
            }
        }
        catch (ArgumentOutOfRangeException)
        {

        }
        return printMe;
    }
}