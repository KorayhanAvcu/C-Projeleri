// See https://aka.ms/new-console-template for more information
Console.WriteLine("Kaç tane sayi gireceksiniz ? : ");
int n = int.Parse(Console.ReadLine());
List<int> kucukler= new List<int>();
List<int> buyukler= new List<int>();
int sayi, sonuc, ksonuc=0,bsonuc=0;

for(int i=0;i<n;i++){
    Console.Write("Sayi giriniz: ");
    sayi=int.Parse(Console.ReadLine());
    if(sayi>67){
        sonuc=67-sayi;
        sonuc*=sonuc;
        buyukler.Add(sonuc);
    }
    else{
        sonuc=67-sayi;
        kucukler.Add(sonuc);
    }
}
foreach (int kucuk in kucukler)
{
    ksonuc+=kucuk;
}
foreach (int buyuk in buyukler)
{
    bsonuc+=buyuk;
}
Console.Write(ksonuc + " " + bsonuc);
