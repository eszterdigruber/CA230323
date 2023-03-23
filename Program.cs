using System.IO;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static List<Felfedezesek> Felfed_List = new List<Felfedezesek>();
        static void Main(string[] args)
        {
            Feladat4(); Console.WriteLine("\n-------------------------------\n");
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
        }
    }
}