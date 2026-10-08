namespace Ders02a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiziListe diziliste = new(5, 3.14, "Ahmet");

            diziliste[2] = "Mehmet";

            if(!diziliste.SonaEkle(true))
                Console.WriteLine("Eleman eklenemedi.");

            foreach(var oge in diziliste)
                Console.WriteLine(oge);


        }
    }
}
