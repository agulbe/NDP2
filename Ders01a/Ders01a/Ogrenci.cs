namespace Ders01a
{
    public class Ogrenci : IComparable
    {
        public int Numara { get; set; }
        public string Ad { get; set; }

        public int CompareTo(object? obj)
        {
            Ogrenci ogr = obj as Ogrenci;
            return Numara - ogr.Numara;
        }

        public override string ToString()
        {
            return Numara + " " + Ad;
        }
    }
}
