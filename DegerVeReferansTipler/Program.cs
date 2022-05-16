using System;
using System.Collections.Generic;
using System.Linq;

namespace DegerVeReferansTipler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int, decimal, float, double, bool(true false 0,1) = değer tipleri
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 ?? cevap 30!
            Console.WriteLine(sayi1);

            //array(dizi), class(sınıf), interface = referans tipleri
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 3000 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ?? cevap 999!


        }
    }
}
