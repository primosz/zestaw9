using System;
using System.Collections.Generic;
using System.Linq;

namespace LookUp
{
    class Program
    {

        class Samochod
        {
            public string Marka;
            public double Silnik;
            public long KM;
        }
        static void Main(string[] args)
        {
            
            List<Samochod> packages = new List<Samochod> { new Samochod { Marka = "Volvo", Silnik = 2.5, KM = 165 },
                                                 new Samochod { Marka = "Volkswagen", Silnik = 1.6, KM = 98 },
                                                 new Samochod { Marka = "Audi", Silnik = 6.0, KM = 312 },
                                                 new Samochod { Marka = "Lamborghini", Silnik = 4.5, KM = 280},
                                                 new Samochod { Marka = "Ferrari", Silnik = 8.2, KM = 515 } };

     
            Lookup<char, string> lookup = (Lookup<char, string>)packages.ToLookup(p => Convert.ToChar(p.Marka.Substring(0, 1)),
                                                            p => p.Marka + " " + p.Silnik);

          
            foreach (IGrouping<char, string> grupaAut in lookup)
            {
               
                Console.WriteLine(grupaAut.Key);
            
                foreach (string str in grupaAut)
                    Console.WriteLine("    {0}", str);
            }

        
           
            int count = lookup.Count;
            
            IEnumerable<string> cgroup = lookup['V'];

        
            Console.WriteLine("\nSamochody zaczynające się na 'V':");
            foreach (string str in cgroup)
                Console.WriteLine(str);

           
            Console.WriteLine(lookup.Contains('r'));
        }
    }
}
