using System;
/// <summary> Queue </summary>
public class Queue<T>
{
    public string CheckType()
    {
        return typeof(T).ToString();
    }
}
