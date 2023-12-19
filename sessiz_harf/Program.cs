//Ilk olarak bir metin alacağız.
Console.Write("Metin giriniz: ");
string metin = Console.ReadLine();

//bosluklara gore parcalayıp bir metin  dizisine atacağız.
string[] metin_ = metin.Split(" ");
string gccMetin = "";
List<bool> sonuc= new List<bool>();
string sessizHarfler="bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
int kontrol=0;
for (int i = 0; i < metin_.Length; i++)
{
    gccMetin=metin_[i];
    for (int j = 0; j < gccMetin.Length-1; j++)
    {
        if(sessizHarfler.Contains(gccMetin[j]) && sessizHarfler.Contains(gccMetin[j+1]) && kontrol==0){
            sonuc.Add(true);
            kontrol=1;
        }
    }
    if(kontrol==0)
        sonuc.Add(false);
    else
        kontrol=0;
}
foreach (bool item in sonuc)
{
    Console.Write(item + " ");
}