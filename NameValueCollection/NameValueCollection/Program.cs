using System;
using System.Collections.Specialized;

class Program
{
    static NameValueCollection GetCollection()
    {
        NameValueCollection collection = new NameValueCollection();
        collection.Add("Piotr", "KFC");
        collection.Add("Paweł", "MCDonald");
        collection.Add("Paweł", "BurgerKing");
        collection.Add("Piotr", "KEBAB");
        return collection;
    }

    static void Main()
    {
        NameValueCollection collection = GetCollection();
       // foreach (string key in collection.AllKeys) // <-- bez duplikatow
       // {
        //    Console.WriteLine(key);
       // }

        foreach (string key in collection)
        {
            Console.WriteLine("{0} {1}", key, collection[key]);
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(collection["Piotr"]); // <-- to samo co getvalue
        Console.WriteLine(collection["Grzegorz"] == null); // <-- true bo nie ma takiego
                                                    // czy cos jest w kolekcji
        Console.WriteLine(collection.HasKeys());

        // Write the first key.
        Console.WriteLine(collection.GetKey(0));

        // Get the first value.
        string value = collection.Get(0);
        Console.WriteLine(value);
    }
}