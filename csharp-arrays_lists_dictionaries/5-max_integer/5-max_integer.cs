using System;
using System.Collections.Generic;

public class List
{
    public static int MaxInteger(List<int> myList)
    {
	int biggs;
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return (-1);
        }

        biggs = myList[0];
        
	foreach (var element in myList)
	{
		if (element > biggs)
		{
			biggs = element;
		}
	}
	return (biggs);
    }
}