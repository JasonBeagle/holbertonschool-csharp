using System;
/// <summary> Queue class </summary>
public class Queue<T>
{
    /// <summary> Node class </summary>
    public class Node
    {
        /// <summary> value of node </summary>
        public T value { get; set; }
        /// <summary> next node </summary>
        public Node next { get; set; }

        /// <summary> constructor for node </summary>
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    private Node head;
    private Node tail;
    private int count;

    /// <summary> creates and adds new node to end of queue </summary>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }

        count++;
    }

    /// <summary> gets count </summary>
    public int Count()
    {
        return count;
    }
}
