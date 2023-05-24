using System;
using System.Collections.Generic;

/// <summary> class Obj </summary>
public class Obj
{
    /// <summary> prints names of properties and methods of an object </summary>
    public static void Print(object myObj)
    {
        string ObjName = myObj.GetType().Name;
        Type ObjType = myObj.GetType();
        Console.WriteLine("{0} Properties:", ObjName);
        foreach (var p in ObjType.GetProperties())
        {
            Console.WriteLine(p.Name);
        }
        Console.WriteLine("{0} Methods:", ObjName);
        foreach (var m in ObjType.GetMethods())
        {
            Console.WriteLine(m.Name);
        }
    }
}