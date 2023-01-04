// See https://aka.ms/new-console-template for more information


int limit=100;
int tekSayilar=0;
int ciftSayilar=0;

for (int i = 0; i < limit; i++)
{
    if (i % 2 == 0 )
        ciftSayilar+=i;
    else
        tekSayilar+=i;
}

Console.WriteLine( "Tek ayıların toplamı: " + tekSayilar);
Console.WriteLine(  "Çift sayıların toplamı: " + ciftSayilar);

