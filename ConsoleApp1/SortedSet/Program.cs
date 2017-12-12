using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create list with elements.
        List<string> list = new List<string>();
        list.Add("sam");
        list.Add("allen");
        list.Add("perls");
        list.Add("perls");

        // Created sorted set from list.
        SortedSet<string> set = new SortedSet<string>(list);

        // Display contents.
        foreach (string val in set)
        {
            Console.WriteLine(val);
        }
    }
}