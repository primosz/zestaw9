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
                                                 new Samochod { Marka = "Atmos", Silnik = 4.5, KM = 280},
                                                 new Samochod { Marka = "Lanos", Silnik = 4.5, KM = 280},
                                                 new Samochod { Marka = "Fiesta", Silnik = 4.5, KM = 280},
                                                 new Samochod { Marka = "Ferrari", Silnik = 8.2, KM = 515 },
            new Samochod { Marka = "Auris", Silnik = 8.2, KM = 515 }};

     
            Lookup<string, string> lookup = (Lookup<string, string>)packages.ToLookup(p => (p.Marka.Substring(0, 3)),
                                                            p => p.Marka + " " + p.Silnik);

          
            foreach (IGrouping<string, string> grupaAut in lookup)
            {
               
                Console.WriteLine(grupaAut.Key);
            
                foreach (string str in grupaAut)
                    Console.WriteLine("    {0}", str);
            }

        
           
            int count = lookup.Count;
            
            IEnumerable<string> cgroup = lookup["Vo"];

        
           
        }
    }
}
