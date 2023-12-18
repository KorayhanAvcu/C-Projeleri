Console.Write("Metin Giriniz: ");
string metin=Console.ReadLine();
string gcc="";
for (int i = metin.Length-1; i >= 0; i--)
{
    gcc+=metin[i];
}
Console.WriteLine("Tersi : " + gcc);
