//string adi = "Cem";
//int yas = 26;

Kurs kurs1 = new Kurs();  //class değişkeni tanımlamak için kullanılır.
kurs1.KursAdi = "C#";
kurs1.Egitmen = "Engin Demiroğ";
kurs1.IzlenmeOrani = 68;

Kurs kurs2 = new Kurs();  
kurs2.KursAdi = "Java";
kurs2.Egitmen = "Cem Su";
kurs2.IzlenmeOrani = 50;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Python";
kurs3.Egitmen = "Ali Veli";
kurs3.IzlenmeOrani = 86;

//Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

foreach (var Kurs in kurslar)
{
    Console.WriteLine(Kurs.KursAdi + " : " + Kurs.Egitmen);
}

class Kurs
{
    public string KursAdi { get; set; } //prop yazıp 2 kere TAB'a basarsan şablonu otomatik oluşturur.
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}
