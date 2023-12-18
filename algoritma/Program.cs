Console.Write("Kelime giriniz:");
string metin = Console.ReadLine();
Console.Write("Sayi Giriniz:");
int sayi=int.Parse(Console.ReadLine());
string gcc="";
for (int i = 0; i < metin.Length; i++)
{
    if(i==sayi)
        continue;
    else{
        gcc += metin[i];
    }
        
}
Console.WriteLine("Sonuc : " + gcc);