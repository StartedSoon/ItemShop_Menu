Console.WriteLine("Ne kadar bakiyeniz var ?");
int bakiye = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("1 - İp");
Console.WriteLine("2 - Meşale");
Console.WriteLine("3 - Tırmanış Ekipmanı");
Console.WriteLine("4 - Temiz Su");
Console.WriteLine("5 - Bıçak");
Console.WriteLine("6 - Kano");
Console.WriteLine("7 - Erzak Stoğu");
Console.WriteLine("");
Console.Write("Kaç numaralı eşyayı satın almak istiyorsunuz ?");

int esyaSecenek = Convert.ToInt32(Console.ReadLine());

string esyaAdı = esyaSecenek switch
{
    1 => "İp",
    2 => "Meşale",
    3 => "Tırmanış Ekipmanı",
    4 => "Temiz Su",
    5 => "Bıçak",
    6 => "Kano",
    7 => "Erzak Stoğu",
    _ => "Bilinmiyor"
};
int fiyat = esyaSecenek switch
{
    1 => 10,
    2 => 15,
    3 => 25,
    4 => 1,
    5 => 20,
    6 => 200,
    7 => 1,
    _ => 0
};
Console.WriteLine("Eşyayı kimin adına alıyorsunuz ?");
string satınAlanKisiAdi = Console.ReadLine();


if (satınAlanKisiAdi == "Furkan")
{
    fiyat = fiyat / 2;
    Console.WriteLine("%50 .");
}

if (fiyat > bakiye)
{
    Console.WriteLine("Bu ürünü satın alamazsınız.");
}
else
{
    Console.WriteLine("Ürünü başarıyla satın aldınız.");
    bakiye = bakiye-fiyat;
    Console.WriteLine($"Mevcut Bakiye {bakiye} TL");
}
Console.ReadKey();

