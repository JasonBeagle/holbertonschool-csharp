using System;
using System.Collections.Generic;

public class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> Node = myLList.AddFirst(n);
        return Node;
    }
}