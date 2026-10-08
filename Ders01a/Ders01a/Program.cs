using System.Collections;

namespace Ders01a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ArrayList
            ArrayList liste1 = new ArrayList();
            ArrayList liste2 = new ArrayList(5);
            

            // Add metodu olan koleksiyonlara tanımlama sırasında öğe girilebilir.
            ArrayList liste3 = new() { 1, 2, "Ahmet" };


            // ArrayList'e öğe ekleme
            // Add(<öğe>)
            liste1.Add(5);
            liste1.Add("Merhaba");
            liste1.Add(new Ogrenci() { Numara=1005, Ad="Ali OK"});
            liste1.Add(new int[3]{ 1, 2, 3});

            // Insert(<indis>, <öğe>): indis ile belirlenen sıraya öğeyi ekler.
            liste1.Insert(2, 3.14);

            // AddRange(<liste>): listenin sonuna başka bir liste ekle
            liste1.AddRange(liste3);

            // InsertRange(<indis>, <liste>):
            liste1.InsertRange(2, liste2);

            // ArrayList içindeki bir öğenin indisini bulma
            // IndexOf(<öğe>): int [0, Count): öğe listede var, -1: öğe listede yok.
            Console.WriteLine(liste1.IndexOf(3));

            // Listeyi yazdır
            Console.WriteLine(" > Ters çevirmeden önce ...");
            foreach(var oge in liste1)
                Console.WriteLine(oge);

            // Listenin sırasını ters çevirme
            liste1.Reverse();


            // Listeyi yazdır
            Console.WriteLine(" > Ters çevirdikten sonra...");
            foreach (var oge in liste1)
                Console.WriteLine(oge);


            // Liste elemanlarını sıralama
            // Sort()
            ArrayList liste4 = new() { 5.25, 23.0, 3.45, 12.0, 87.0, 4.54, 1.27, 65.0};
            ArrayList liste5 = new() { "Can","Eda","Ali","Ela","Naz","Gül"};
            ArrayList liste6 = new() {
                new Ogrenci() {Numara=5, Ad="Mehmet"},
                new Ogrenci() {Numara=12, Ad="Veli"},
                new Ogrenci() {Numara=8, Ad="Güler"},
                new Ogrenci() {Numara=3, Ad="Ayşe"},
                new Ogrenci() {Numara=7, Ad="Hilal"},
            };
            liste6.Sort();

            // Listeyi yazdır
            Console.WriteLine(" > Sıraladıktan sonra...");
            foreach (var oge in liste6)
                Console.WriteLine(oge);
            Console.WriteLine(" ------------------------------------------- ");

            // Listenin bir kısmını almak
            // GetRange(<indis>, <sayi>)
            ArrayList altliste = liste6.GetRange(1, 2);

            // Listeyi yazdır
            Console.WriteLine(" > Alt Liste...");
            foreach (var oge in altliste)
                Console.WriteLine(oge);
            Console.WriteLine(" ------------------------------------------- ");

            // Bir öğenin listede olup olmadığını test etme
            // Contains(<öğe>): bool
            if (liste1.Contains(3))
                Console.WriteLine("3 listede var.");
            else
                Console.WriteLine("3 listede yok.");
            // ArrayList'ten öğe silme
            // Remove(<öğe>): öğe siler
            // RemoveAt(<indis>): verilen sıradaki öğeyi siler
            // liste1.Remove(5);
            // liste1.RemoveAt(2);

            // ArrayList'in öğe sayısını öğrenme
            // Count: özellik, int
            Console.WriteLine("Liste1: "+liste1.Count);
            Console.WriteLine("Liste2: "+liste2.Count);
        }
    }
}
