
Console.Write("Metin Giriniz : ");
string metin = Console.ReadLine();

string[] metin_=metin.Split(' ');
string metin2="";

for (int i = 0; i < metin_.Length; i++)
{
    metin2=metin_[i];
    if(metin2.Length>=2){
        char ilkKarakter=metin2[0];
        char sonKarakter=metin2[metin2.Length-1];
        //substring ile belirli aralığı alıyoruz.
        metin_[i]=sonKarakter + metin2.Substring(1, metin2.Length-2) + ilkKarakter;
    }
    
}
//araya bosluk atarak yeni bir string oluşturuyoruz arrayden.
string yeniMetin = string.Join(" ",metin_);
Console.WriteLine(yeniMetin);