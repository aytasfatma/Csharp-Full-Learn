// See https://aka.ms/new-console-template for more information



/*İki adet int değişken tanımlayınız. Bu iki sayının arkadaş sayı olup olmadığını console çıktısı olarak veriniz. 


Bu ödev ile ilgili sorular
Sayıları 220 ve 284 olarak verdiğinizde arkadaş sayı çıkıyor mu?

*/






int sayi1 = 220;
int sayi2 = 284;
int arkadas = 0;
int arkadas2 = 0;
for (int i = 1; i < sayi1; i++) 
{
    if (sayi1 % i == 0)
    {
        arkadas = arkadas + i;


    }
}
if (arkadas == sayi2)
{
   
    for (int j = 1; j <sayi2; j++)
    {
        if (sayi2 % j == 0)
        {
            arkadas2 = arkadas2 + j;

        }
    }
    if (sayi1 == arkadas2)
    {
        Console.WriteLine("arakadas sayidirlar");
    }

    else
    {
        Console.WriteLine("arkadas sayi degildir");
    }

}



else
{
    Console.WriteLine("arkadas sayi degildir");
}




