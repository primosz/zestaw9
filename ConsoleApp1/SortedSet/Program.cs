using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
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

        
        SortedSet<string> set = new SortedSet<string>(list);

      
        foreach (string val in set)
        {
            Console.WriteLine(val);
        }
        Console.WriteLine(set.Count);
       
        //usun te, ktore zaczynaja sie na p

        set.RemoveWhere(element => element.StartsWith("P"));
        Console.WriteLine();

        
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

        // dodawanie bez duplikatow
        set.UnionWith(list2);

        // wyswietl
        foreach (string val in set)
        {
            Console.WriteLine(val);
        }
    }
}