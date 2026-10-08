using System.Collections;
namespace Ders03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kuyruk: Queue
            // FIFO: Fırst-In-Fırst-Out

            Queue kuyruk = new();            // Non-generic
            Queue<string> kelimeler = new(); // Generic System.Collections.Generic
            Queue<Ogrenci> ogrenciler = new();


            // Kuyruğa öğe eklemek
            // Enqueue(<öğe>)
            kuyruk.Enqueue("Ahmet");
            kuyruk.Enqueue("Zekiye");
            kuyruk.Enqueue(3.75);
            kuyruk.Enqueue(255);
            kuyruk.Enqueue(true);

            kelimeler.Enqueue("Adalet");
            kelimeler.Enqueue("Nezaket");
            kelimeler.Enqueue("Liyakat");
            kelimeler.Enqueue("İstiklal");
            // kelimeler.Enqueue(12);
            // kelimeler.Enqueue(3.14);
            // kelimeler.Enqueue(false);
            // kelimeler.Enqueue('A');

            ogrenciler.Enqueue(new Ogrenci { Numara = 2401060012L, Ad = "Rüveyda KAKŞİ" });
            ogrenciler.Enqueue(new Ogrenci { Numara = 2401060027L, Ad = "Mehmet Salih SAMİROĞLU" });
            ogrenciler.Enqueue(new Ogrenci { Numara = 2301060007L, Ad = "Yahya Arda SANDIKÇI" });

            // Kuyruktaki sıradaki öğe
            // Peek() : Seç
            Console.WriteLine(kuyruk.Peek());

            // Sıradaki öğeye işlem yapmak
            // Dequeue()
            Console.WriteLine($"Kuyrukta {kuyruk.Count} öğe var.");
            Console.WriteLine(" > "+kuyruk.Dequeue());
            Console.WriteLine($"Kuyrukta {kuyruk.Count} öğe kaldı. Artık kuyruğun başında {kuyruk.Peek()} var.");

            // Kuyruktaki öğe sayısı
            // Count
            object?[] dizi = kuyruk.ToArray();

            for (int i = 0; i <kuyruk.Count;i++)
                Console.WriteLine(dizi[i]);

            foreach(object nesne in kuyruk)
                Console.WriteLine(nesne);

            if (kuyruk.Contains("Zekiye"))
                Console.WriteLine("Zekiye hâlâ bekliyor.");
            else
                Console.WriteLine("Zekiye'nin işlemi tamamlanmış.");
        }
    }
}
