// See https://aka.ms/new-console-template for more information

//FOR DÖNGÜLERİ
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
//WHILE DÖNGÜSÜ

char character='a';

while (character<='z'){
    Console.Write(character);
    character++;
}
    Console.WriteLine("");
//FOREACH DÖNGÜLERİ
string [] arabalar ={"Ford","Totoya","Audi"};

foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}



