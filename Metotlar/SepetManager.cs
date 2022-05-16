﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        //naming convention - isimlendirme kuralı
        //syntax 
        public void Ekle(Urun urun) //normal parantez görürsek metotların çalışması demektedir
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urun.Adi);
        }

        public void Ekle2 (string urunAdi, string aciklama, double fiyat, int stokAdeti)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urunAdi);
        }
    }
}
