using System;

class Program
{
    static void Main(string[] args)
    {
        for(int i = 0; i < 100; i++)
        {
            if (i != 99)
            {
                Console.Write(i.ToString("D2") + ", ");
            }
            else
                Console.Write(i);
        }
    }
}
