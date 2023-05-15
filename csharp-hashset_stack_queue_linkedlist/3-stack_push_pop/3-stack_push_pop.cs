using System;
using System.Collections.Generic;

public class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: " + aStack.Count);

        if (aStack.Count > 0)
        {
            Console.WriteLine("Top item: " + aStack.Peek());
        }
        else
        {
            Console.WriteLine("Stack is empty");
        }

        Console.WriteLine("Stack contains " + search + ": " + aStack.Contains(search));

        if (aStack.Contains(search))
        {
            Stack<string> tempStack = new Stack<string>();

            while (aStack.Count > 0)
            {
                string item = aStack.Pop();

                if (item == search)
                {
                    break;
                }
                else
                {
                    tempStack.Push(item);
                }
            }

            Stack<string> reversedStack = new Stack<string>(tempStack);
            aStack = reversedStack;
        }

        aStack.Push(newItem);

        return aStack;
    }
}
