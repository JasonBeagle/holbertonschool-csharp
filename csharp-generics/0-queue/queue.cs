using System;
/// <summary> Queue class </summary>
public class Queue<T>
{
    /// <summary> returns queue type </summary>
    public string CheckType()
    {
        return typeof(T).ToString();
    }
}
