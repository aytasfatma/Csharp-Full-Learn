// See https://aka.ms/new-console-template for more information




// dizi ile 
string[] sehirler = new string[] { "ankara", "istanbul", "izmir" };
Console.WriteLine(sehirler.Length);
sehirler = new string[4];
sehirler[3] = "bursa";
foreach (var sehir in sehirler)
{

    Console.WriteLine(sehir);

}
//liste ile 
List<String> sehiler = new List<string>()
 { "ankara","istanbul","izmir"};
Console.WriteLine(sehiler.Count);
sehiler.Add("bursa");
sehiler.Remove("istanbul");
sehiler.Add("artvin");
bool sonuc = sehiler.Contains("izmir");
Console.WriteLine(sehiler.Count);
Console.WriteLine(sonuc);