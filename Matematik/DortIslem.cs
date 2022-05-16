using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class DortIslem
    {
        public void Topla(int sayi1, int sayi2) // Metot örneği
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }
        public void Cıkar(int sayi1, int sayi2)
        {
            int cıkar = sayi1 - sayi2;
            Console.WriteLine("Sonuç : " + cıkar);
        }
        public void Carpma(int sayi1, int sayi2)
        {
            int carpma = sayi1 * sayi2;
            Console.WriteLine("Sonuç : " + carpma);
        }
        public void bolme(int sayi1, int sayi2)
        {
            int bolme = sayi1 / sayi2;
            Console.WriteLine("Sonuç : " + bolme);
        }
    }
}
