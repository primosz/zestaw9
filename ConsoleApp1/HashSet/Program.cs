using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 3, 4, 5 };
        int[] array3 = { 9, 10, 11 };

        HashSet<int> set = new HashSet<int>(array1);
        bool a = set.Overlaps(array2);
        bool b = set.Overlaps(array3);

        // Display results.
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}