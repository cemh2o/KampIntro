using System;
using System.Collections.Generic;
using System.Linq;

namespace Metotlar
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Urun classı tanımladıktan sonra ürün ekleme işlemi yaptık (urun1, urun2)
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 500;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 100;

            // Ürünler için dizi (array) oluşturduk (2 ürünü urunler klasörüne atmak gibi örneklendirilebilir.)
            Urun[] urunler = new Urun[] { urun1, urun2, }; 

            // type safe = tip güvenli (Urun)
            //foreach döngüsünü kullanarak var olan ürünleri ekrana yazdırdık.
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("-----------------");

            }

            Console.WriteLine("-------------Metotlar---------------");

            //instance - örnek (class örneği)
            //encapsulation (kapsülleme) tekniğini kullandık (ürünler için class açarak)
            SepetManager sepetManager= new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //encapsulation Ekle2 kapsülleme yok (hatalı yöntem örneği) kapsülleme örneği yukarda verilmiştir.
            sepetManager.Ekle2("Armut", "Yeşil", 12, 500);
            sepetManager.Ekle2("Elma", "Yeşil", 12, 100);
            sepetManager.Ekle2("Karpuz", "Kırmızı", 12, 50);
        }
    }
}
