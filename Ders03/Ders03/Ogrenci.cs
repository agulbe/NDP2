namespace Ders03
{
    public class Ogrenci
    {
        public long Numara { get; set; }
        public string? Ad { get; set; }

        public override string ToString()
        {
            return Numara + " " + Ad;
        }
    }
}
