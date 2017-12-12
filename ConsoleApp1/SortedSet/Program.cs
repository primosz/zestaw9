using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create list with elements.
        List<string> list = new List<string>();
        list.Add("Piotr");
        list.Add("Grzegorz");
        list.Add("Marcin");
        list.Add("Paweł");
        list.Add("Ania");
        list.Add("Paula");
        list.Add("Krzysiu");
        list.Add("Zbyszek");
        list.Add("Stefan");

        // Created sorted set from list.
        SortedSet<string> set = new SortedSet<string>(list);

        // Display contents.
        foreach (string val in set)
        {
            Console.WriteLine(val);
        }
        Console.WriteLine(set.Count);
       

        set.RemoveWhere(element => element.StartsWith("P"));
        Console.WriteLine();

        // Display contents.
        foreach (string val in set)
        {
            Console.WriteLine(val);
        }
        Console.WriteLine(set.Count);
        set.Clear();
        Console.WriteLine(set.Count);
        Console.WriteLine();

        SortedSet<string> set2 = new SortedSet<string>();
        set.Add("a");
        set.Add("z");
        set.Add("x");

        List<string> list2 = new List<string>();
        list.Add("a");
        list.Add("y");

        // Union the two collections.
        set.UnionWith(list2);

        // Enumerate.
        foreach (string val in set)
        {
            Console.WriteLine(val);
        }
    }
}