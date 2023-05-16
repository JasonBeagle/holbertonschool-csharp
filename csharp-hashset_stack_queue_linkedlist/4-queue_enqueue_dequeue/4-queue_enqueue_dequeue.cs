using System;
using System.Collections.Generic;

public class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aQueue.Count);

        if (aQueue.Count != 0)
        {
            Console.WriteLine("First item: {0}", aQueue.Peek());
        }
        else
        {
            Console.WriteLine("Queue is empty");
        }

        Console.WriteLine("Queue contains \"{0}\": {1}", search, aQueue.Contains(search));

        if (aQueue.Contains(search))
        {
            while (aQueue.Count != 0)
            {
                string item = aQueue.Dequeue();

                if (item == search)
                {
                    break;
                }
            }
        }

        aQueue.Enqueue(newItem);

        return aQueue;
    }
}
