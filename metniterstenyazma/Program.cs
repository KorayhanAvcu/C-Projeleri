
Console.WriteLine("Bir string ifade giriniz:");
string metin = Console.ReadLine();

string sonuc = Degistir(metin);
Console.WriteLine("Sonuç: " + sonuc);
    

static string Degistir(string metin){
    char[] charDizisi = metin.ToCharArray();
    char temp;
    for (int i = 0; i < charDizisi.Length-1; i++)
    {
        
        temp = charDizisi[i+1];
        charDizisi[i+1]=charDizisi[i];
        charDizisi[i] = temp;
        
    }
    return new string(charDizisi);

} 
