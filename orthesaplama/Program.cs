Console.Write("Fibonacci toplami icin bir derinlik giriniz: ");
int derinlik = int.Parse(Console.ReadLine());
Console.WriteLine("Sonuc : " + fibOrtalama(derinlik));

static double fibOrtalama(int d)
{
    
    if (d <= 0)
    {
        return 0.0;
    }

    int toplam = 0;
    double sonuc = 0.0;
    int[] fib = new int[d];
    fib[0] = 0;
    fib[1] = 1;
    toplam = fib[0] + fib[1];
    
    for (int i = 2; i < d; i++)
    {
        fib[i] = Fib(i);
        toplam += fib[i];
    }

    sonuc = (double)toplam / d;
    return sonuc;
}


// buradaki derinlik muhabbeti kafamı karıştırdığından iki versiyonunuda yazıyorum
/* 
static double fibOrtalama(int d)
{
    
    if (d <= 0)
    {
        return 0.0;
    }

    int toplam = 0;
    double sonuc = 0.0;
    int[] fib = new int[d+1];
    fib[0] = 0;
    fib[1] = 1;
    toplam = fib[0] + fib[1];
    
    for (int i = 2; i <= d; i++)
    {
        fib[i] = Fib(i);
        toplam += fib[i];
    }

    sonuc = (double)toplam / d;
    return sonuc;
}
 */
static int Fib(int index){
    if(index==0) return 0;
    else if(index==1) return 1;
    else return Fib(index-2)+Fib(index-1);
}