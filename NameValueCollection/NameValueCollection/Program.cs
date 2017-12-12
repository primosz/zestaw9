using System;
using System.Collections.Specialized;

class Program
{
    static NameValueCollection GetCollection()
    {
        NameValueCollection collection = new NameValueCollection();
        collection.Add("Sam", "Dot Net Perls");
        collection.Add("Bill", "Microsoft");
        collection.Add("Bill", "White House");
        collection.Add("Sam", "IBM");
        return collection;
    }

    static void Main()
    {
        NameValueCollection collection = GetCollection();
        foreach (string key in collection.AllKeys) // <-- No duplicates returned.
        {
            Console.WriteLine(key);
        }

        Console.WriteLine(collection["Sam"]); // <-- Same as GetValues
        Console.WriteLine(collection["X"] == null); // <-- Not found
                                                    // Write whether the collection has keys.
        Console.WriteLine(collection.HasKeys());

        // Write the first key.
        Console.WriteLine(collection.GetKey(0));

        // Get the first value.
        string value = collection.Get(0);
        Console.WriteLine(value);
    }
}