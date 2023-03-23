using System.IO;
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