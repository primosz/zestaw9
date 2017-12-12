using System;
using System.Collections;

class Program
{
    static Hashtable GetHashtable()
    {
        // Create and return new Hashtable.
        Hashtable hashtable = new Hashtable();
        hashtable.Add(1000,"Tysiąc");
        hashtable.Add(50, "Pięćdziesiąt");
        hashtable.Add(600, "Sześćset");
        return hashtable;
    }

    static void Main()
    {
        Hashtable hashtable = GetHashtable();

        // Display the keys.
        foreach (int key in hashtable.Keys)
        {
            Console.WriteLine(key);
        }

        // Display the values.
        foreach (string wart in hashtable.Values)
        {
            Console.WriteLine(wart);
        }

        // See if the Hashtable contains this key.
        Console.WriteLine(hashtable.ContainsKey(100));

        // Test the Contains method.
        // ... It works the same way.
        Console.WriteLine(hashtable.Contains(600));

        // Get value of Area with indexer.
        string value = (string)hashtable[50];

        // Write the value of Area.
        Console.WriteLine(value);

        int count = hashtable.Count;
        Console.WriteLine(count);

        // Clear the Hashtable.
        hashtable.Clear();

        // Get Count of Hashtable again.
        Console.WriteLine(hashtable.Count);
    }
}