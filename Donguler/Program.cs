//string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
//string kurs2 = "Programlama Başlangıç için Temel Kurs";
//string kurs3 = "Java";

// Array = Dizi
// Array (dizi) oluşturmak için string[] kurslar = new string[] { };

string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
    "Programlama Başlangıç için Temel Kurs",
    "Java", "Python", "C#" };


for (int i = 0; i < kurslar.Length; i++) // i=i+2 olabilir  Length = Eleman Sayısı
{
    Console.WriteLine(kurslar[i]);
}

Console.WriteLine("For Bitti"); 
foreach (string kurs in kurslar)  //Dizi temellli yapıları kolay dolaşmak için kullanılır.
{
    Console.WriteLine(kurs);
}

Console.WriteLine("sayfa sonu");

int sayi = 100;
while (sayi > 100)
{
    Console.WriteLine(sayi);
    sayi--;
}