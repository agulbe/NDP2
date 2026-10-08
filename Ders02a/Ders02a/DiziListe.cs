using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Ders02a
{
    public class DiziListe : IEnumerable
    {
        // Verileri saklayan her tür veri kabul eden dizi
        private object?[] dizi;

        // Eleman sayısını güvenli bir şekilde tutan özellik
        private int elemanSayisi; // Alan

        public int ElemanSayisi  // Salt-okunur özellik
        {
            get { return elemanSayisi; }            
        }


        // Kurucucular

        // Varsayılan
        public DiziListe()
        {
            elemanSayisi = 0;
            dizi = new object?[0];
        }


        // Herhangi bir sayıda ve herhangi bir türde öğe kabul eden kurucu
        public DiziListe(params object[] ogeler)
        {
            elemanSayisi = ogeler.Length;
            dizi = new object[elemanSayisi];

            for(int i = 0; i < elemanSayisi; i++) 
                dizi[i] = ogeler[i];
        }

        // Endeksleyici
        public object? this[int indis]
        {
            get
            {
                if(indis <0 || indis >= elemanSayisi)
                    throw new IndexOutOfRangeException("İndis sınırların dışına taştı!");
                return dizi[indis];
            }
            set
            {
                if (indis < 0 || indis >= elemanSayisi)
                    throw new IndexOutOfRangeException("İndis sınırların dışına taştı!");
                dizi[indis] = value;
            }
        }

        // Numaralandırıcı
        public IEnumerator GetEnumerator()
        {
            foreach(object? nesne in dizi)
                yield return nesne;
        }

        // Metodlar

        // Sona ekleme
        //public void SonaEkle(object nesne)
        //{

        //    object?[] yenidizi = new object?[elemanSayisi+1];

        //    for (int i = 0; i < elemanSayisi; i++)
        //        yenidizi[i] = dizi[i];

        //    yenidizi[elemanSayisi] = nesne;

        //    elemanSayisi++;

        //    dizi = yenidizi;
        //}

        public bool SonaEkle(object nesne)
        {
            try
            {
                object?[] yenidizi = new object?[elemanSayisi + 1];

                for (int i = 0; i < elemanSayisi; i++)
                    yenidizi[i] = dizi[i];

                yenidizi[elemanSayisi] = nesne;

                elemanSayisi++;

                dizi = yenidizi;
            }
            catch
            {
                return false;
            }
            return true;
        }

        //public int SonaEkle(object nesne)
        //{
        //    try
        //    {
        //        object?[] yenidizi = new object?[elemanSayisi + 1];

        //        for (int i = 0; i < elemanSayisi; i++)
        //            yenidizi[i] = dizi[i];

        //        yenidizi[elemanSayisi] = nesne;

        //        elemanSayisi++;

        //        dizi = yenidizi;
        //    }
        //    catch
        //    {
        //        return 0;
        //    }
        //    return 1;
        //}

        // Araya ekleme

        public void ArayaEkle(object? nesne)
        {

        }

    }
}
