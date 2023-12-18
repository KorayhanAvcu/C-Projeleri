
Console.Write("Ucgen cizimi icin boyut giriniz:");
int boyut = int.Parse(Console.ReadLine());
Ucgen(boyut);

static void Ucgen(int boyut){
    for (int i = 1; i <= boyut; i++)
    {
        for (int k = 1; k <= boyut-i; k++)
        {
            Console.Write(" ");
        }
        for (int j = 1; j <= (2*i-1); j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        
    }
}
