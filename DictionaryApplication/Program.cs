using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Dictionary<string, string> friction = new Dictionary<string, string>();
        friction.Add("aditya", "A");
        friction.Add("Akash","B");
        friction["Anup"] ="C";

        foreach (string key in friction.Keys)
        {
            Console.WriteLine("Name:"+ key);
        }
        if (friction.ContainsKey("Anup"))
        {
            Console.WriteLine("Anup's name is :" + friction["Anup"]);
        }
    }
}
