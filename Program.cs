﻿using System.IO;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static List<Felfedezesek> Felfed_List = new List<Felfedezesek>();
        static string KeresVegyjel;
        static void Main(string[] args)
        {
            Feladat4(); Console.WriteLine("\n-------------------------------\n");
            Feladat6(); Console.WriteLine("\n-------------------------------\n");
            Feladat7(); Console.WriteLine("\n-------------------------------\n");
            Feladat8(); Console.WriteLine("\n-------------------------------\n");
            Feladat9(); Console.WriteLine("\n-------------------------------\n");
        }

        private static void Feladat9()
        {
            Console.WriteLine("9.feladat: Statisztika a 19.században");
            int Evszam = 0;
            List<int> Evszamok = new List<int>();
            List<int> Tiszta = new List<int>();
            foreach (var f in Felfed_List)
            {
                if (f.Ev == "Ókor")
                { Evszam = 0; }
                else
                { Evszam = int.Parse(f.Ev); }
                if (1800 < Evszam && Evszam < 1901 )
                {
                    Evszamok.Add(Evszam);
                }
               
            } 
            foreach (var e in Evszamok)
            {
                if (!Tiszta.Contains(e))
                { Tiszta.Add(e); }
            }
            foreach (var t in Tiszta)
            {
                int db = 0;
                foreach (var e in Evszamok)
                {
                    if (t == e)
                    { db++; }
                }
                Console.WriteLine($"{t} : {db}");
            }
        }

        private static void Feladat8()
        {
            Console.WriteLine("8.feladat: Keresés");
            int Szamlalo = 0;
            while (Szamlalo < Felfed_List.Count && KeresVegyjel.ToUpper() != Felfed_List[Szamlalo].Vegyjel.ToUpper())
            { Szamlalo++; }
            if (Szamlalo == Felfed_List.Count)
            {
                Console.WriteLine("Nem volt ilyen elem");
            }
            else
            { Console.WriteLine($"Felfedezés éve: {Felfed_List[Szamlalo].Ev}"); }
        }

        private static void Feladat7()
        {
            Console.WriteLine("7.feladat: Bekérés");
            Console.Write("Kérem adjon meg egy vegyjelet: ");
            KeresVegyjel = Console.ReadLine();
        }

        private static void Feladat6()
        {
            Console.WriteLine("6.feladat: William Ramsay");
            int darab = 0;
            foreach (var f in Felfed_List)
            {
                if (f.Felfedezo.Replace(" ", "").Contains("WilliamRamsay") || f.Felfedezo.Replace(" ", "").Contains("W.Ramsay"))
                {
                    darab++;
                }
            }
            Console.WriteLine($"Ennyi esetben dolgozott William Ramsay együtt: {darab}");
        }

        private static void Feladat4()
        {
            Console.WriteLine("4.feladat: Beolvasás");
            var sr = new StreamReader(@"felfedezesek.csv", Encoding.UTF8);
            string Beolvas = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Beolvas = sr.ReadLine();
                Felfed_List.Add(new Felfedezesek(Beolvas));
            }
            sr.Close();
            Console.WriteLine($"Beolvasott sorok száma: {Felfed_List.Count}");
        }
    }
}