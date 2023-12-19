Console.Write("Kac tane integer ikili sayi gireceksiniz?  : ");
int n = int.Parse(Console.ReadLine());
int[] toplam = new int[n];
int s1,s2,sonuc;
for (int i = 0; i < n; i++)
{
    Console.Write("Sayi Giriniz: ");
    s1=int.Parse(Console.ReadLine());
    Console.Write("Sayi Giriniz: ");
    s2=int.Parse(Console.ReadLine());
    sonuc = ikili(s1,s2);
    toplam[i]=sonuc;

}
for (int i = 0; i < toplam.Length; i++)
{
    Console.Write(toplam[i] + " ");
}
static int ikili(int s1,int s2){
    if(s1==s2)
        return (s1*s2)*(s1*s2);
    else
        return s1+s2;
}