using Cli_20240909;

List<Keres> keresek = [];
using StreamReader sr = new(@"..\..\..\src\NASAlog.txt");
while (!sr.EndOfStream)
{
    keresek.Add(new(sr.ReadLine()));
}
Console.WriteLine($"5.feladat: kerek száma: {keresek.Count}");

int? osszMeret = keresek.Sum(k => k.Meret);
Console.WriteLine($"6- feladat: valaszok összes mérete: {osszMeret} byte");

int vanDomain = keresek.Count(k => k.Domain);
Console.WriteLine($"8. feladat: Domaines kérések: {(float)vanDomain / keresek.Count * 100:0.00}%");

var statisztika = keresek.GroupBy(k => k.Kod);
Console.WriteLine("9. feladat: statisztika: ");
foreach (var grp in statisztika)
{
    Console.WriteLine($"\t{grp.Key}: {grp.Count()} db");
}