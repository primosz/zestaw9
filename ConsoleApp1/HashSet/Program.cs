using System;
using System.Collections.Generic;
using System.Linq;

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
        Console.WriteLine(string.Join("", set));

        char[] array4 = { 'a', 'b', 'c' };
        char[] array5 = { 'b', 'c', 'd' };

        var hash = new HashSet<char>(array4);
        hash.SymmetricExceptWith(array5);

        // Write char array.
        Console.WriteLine(hash.ToArray());
    }
}