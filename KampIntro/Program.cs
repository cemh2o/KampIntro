//Type safety - tip güvenliği
//Do not repeat yourslef - Kendini tekrarlama!!
//Değer Tutucu(alias) string kategoriEtiketi = "Kategori"; burada değer tutucu = kategoriEtiketi

string kategoriEtiketi = "Kategoriler";
bool sistemeGirisYapmisMi = true;
double dolarDun = 7.55;
double dolarBugun = 7.55;


if (dolarDun > dolarBugun)
{
    Console.WriteLine("Azalış Butonu");
}
else if (dolarDun < dolarBugun)
{
    Console.WriteLine("Artış Butonu");
}
else
{
    Console.WriteLine("Değişmedi Butonu");
}

if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Kullanıcı Ayarları Butonu");
}
else
{
    Console.WriteLine("Giriş Yap Butonu");
}
Console.WriteLine(kategoriEtiketi);



