using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        HashSet<String> hash = new HashSet<String> { "JASIU", "STASIU", "PIOTR", "GRZEŚ", "ANNA", "MARIA", "TOBIASZ", "KRZYSZTOF" };
        int menuchoice = 0;
        while (menuchoice != 7)
        {

            Console.WriteLine("MENU");
            Console.WriteLine();
            Console.WriteLine("1. Dodaj element do Hashsetu");
            Console.WriteLine("2. Usuń element");
            Console.WriteLine("3. Wyświetl");
            Console.WriteLine("4. Usuń elementy zawierające dane znaki");
          
            Console.WriteLine("5. Exit");


            menuchoice = int.Parse(Console.ReadLine());

            switch (menuchoice)
            {

                
                case 1:
                    Console.WriteLine("Wpisz stringa do dodania:");
                    string temp = Console.ReadLine();
                    hash.Add(temp);
                    Console.WriteLine("Dodano: " + temp);
                   
                    break;
                case 2:
                    Console.WriteLine("Wpisz stringa do usunięcia:");
                    string temp1 = Console.ReadLine();
                    hash.Remove(temp1);
                    Console.WriteLine("Usunięto: " + temp1);
                    break;
                case 3:
                    Console.WriteLine("Twój hashset: ");
                    var count1 = string.Join(", ", hash);
                    Console.WriteLine(count1);
                    break;
                case 4:
                    Console.WriteLine("Wpisz stringa. Elementy zawierające go, zostaną usunięte.");
                    string temp2 = Console.ReadLine();

                    hash.RemoveWhere(c => c.Contains(temp2));
                    break;
                
                case 5:
                    break;  //edit
                default:
                    Console.WriteLine("Sorry, invalid selection");
                    break;
            }
           

            //var hash = new HashSet<char>(array4);
            // hash.SymmetricExceptWith(array5);

            // wyswietl jako tablice
           // Console.WriteLine(hash.ToArray());
        }
    }
}