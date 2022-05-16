using System;
using System.Collections.Generic;
using System.Linq;

namespace DegerVeReferansTipler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int, decimal, float, double, bool(true false = 0,1) = değer tipleri
            // bellekte stack ve heap adında 2 alan vardır. Değer tipleri olanlar stackte gerçekleşiyor.!!
            int sayi1 = 10; // sayı1'in değeri = 10
            int sayi2 = 30; // sayı2'nin değeri = 30
            sayi1 = sayi2; // sayı1'in değeri = sayi2'nin değeri (sadece değer aktarılır) sayi1 30 olur ve bağlantı kopar.
            sayi2 = 65; // sayi2'nin değeri 65 oldu. sayi1'e etkisi yoktur.
            // sayi1 ?? cevap 30!
            


            //array(dizi), class(sınıf), interface = referans tipleri
            // bellekte stack ve heap adında 2 alan vardır. Referans tipleri heap'ta gerçekleşiyor.!!
            int[] sayilar1 = new int[] { 10, 20, 30 }; // sayilar1 stackta tutulur ama array(dizideki) {10,20,30} rakamları heapta tutulur ve arasında adres ile bağlantı oluşturulur.
            int[] sayilar2 = new int[] { 100, 200, 300 }; // sayilar1 deki olayların aynısı gerçekleşir. (new kelimesi bellekte bir adres oluşturur).!!
            sayilar1 = sayilar2; //sayilar2'deki heap'te tutulan adres sayilar1 içinde geçerli olur ve {10,20,30} dizisi iptal edilir.
            sayilar2[0] = 999; //sayilar1 ve sayilar2'nin adresleri aynı olduğundan herhangi bir değişiklikte her ikisi de değişecektir. 0'ıncı elemanı 999 olur.!
            //sayilar1[0] ?? cevap 999!

            


        }
    }
}
