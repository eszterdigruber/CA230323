namespace HelloWorld
{
    internal class Felfedezesek
    {
        //Év;Elem;Vegyjel;Rendszám;Felfedező
        public string Ev;
        public string Elem;
        public string Vegyjel;
        public int Rendszam;
        public string Felfedezo;

        public Felfedezesek(string Sor)
        {
            var dbok = Sor.Split(';');
            this.Ev = dbok[0];
            this.Elem = dbok[1];
            this.Vegyjel = dbok[2];
            this.Rendszam = int.Parse(dbok[3]);
            this.Felfedezo = dbok[4];
        }
    }
}