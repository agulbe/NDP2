namespace Ders01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dizi tanımlama
            int[] dizi1 = new int[5];
            double[] dizi2 = new double[5] {1.5, 3.14, 2.75, 3.87, 4.22};
            short[] dizi3 = { 10, 20, 30, 40, 50, 60, 70};
            byte[] dizi4 = [2, 4, 6, 8, 10];

            foreach (double i in dizi2)
                Console.WriteLine(i);

            for(int i=0; i<dizi2.Length; i+=2)
                Console.WriteLine(dizi2[i]);

            for(int i = 0; i < dizi1.Length; i++)
            {
                Console.Write("Dizinin {0}. elemanı: ", i);
                dizi1 [i] = int.Parse(Console.ReadLine());
            }

            foreach (var i in dizi1)
                Console.WriteLine(i);
            // Dizilerin statik, boyutu değişmez, eleman silip ekleyemezsiniz
            // Baştan boyutunun deklere edilmesi gerekir
            // Dizi elemanlarının hepsi aynı veri tütünde olmalıdır.


        }
    }
}
