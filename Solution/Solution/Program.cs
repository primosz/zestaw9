using System;
using System.Collections;

class Program
{
    static Hashtable GetHashtable()
    {
        
        Hashtable hashtable = new Hashtable();
        hashtable.Add(1000,"Tysiąc");
        hashtable.Add(50, "Pięćdziesiąt");
        hashtable.Add(600, "Sześćset");
        return hashtable;
    }

    static void Main()
    {
        Hashtable hashtable = GetHashtable();

        // wyswietl klucze
        foreach (int key in hashtable.Keys)
        {
            Console.WriteLine(key);
        }

        // wyswietl wartosci
        foreach (string wart in hashtable.Values)
        {
            Console.WriteLine(wart);
        }

        // sprawdz czy zaiwera
        Console.WriteLine(hashtable.ContainsKey(100));

        // to samo
        Console.WriteLine(hashtable.Contains(600));

        // wartosc pod tym indexem
        string value = (string)hashtable[50];

        // wyswietl
        Console.WriteLine(value);

        int count = hashtable.Count;
        Console.WriteLine(count);

        //kasuj
        hashtable.Clear();

        // rozmiar
        Console.WriteLine(hashtable.Count);
    }
}