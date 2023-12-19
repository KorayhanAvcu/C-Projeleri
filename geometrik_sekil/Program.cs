Console.WriteLine("1. Daire \n 2. Ucgen \n 3. Kare \n 4. Dikdörtgen");
Console.Write("Sekil seciniz : ");
int secim = int.Parse(Console.ReadLine());
switch(secim){
    case 1:
        Daire();
        break;
    case 2:
        Ucgen();
        break;
    case 3:
        Kare();
        break;
    case 4:
        Dikdortgen();
        break;
    default:
        Console.WriteLine("Yanlis bir secim girdiniz.");
        break;
}

static int islem(){
    Console.WriteLine("1. Cevre \n 2. Alan");
    int secim = int.Parse(Console.ReadLine());
    return secim;
}

static void Daire(){
    double pi=3.14;
    Console.Write("Yaricapi giriniz : ");
    int yaricap = int.Parse(Console.ReadLine());
    int daireSecim = islem();
    switch(daireSecim){
        case 1:
            DaireCevre(pi,yaricap);
            break;
        case 2:
            DaireAlan(pi,yaricap);
            break;
        default:
            Console.WriteLine("Yanlis bir secim girdiniz");
            break;
    }

}

static void DaireCevre(double pi, int yaricap){
    double dCevre=2*pi*yaricap;
    Console.WriteLine("Dairenin Cevresi : " + dCevre);
}

static void DaireAlan(double pi, int yaricap){
    double dAlan=pi*(yaricap*yaricap);
    Console.WriteLine("Dairenin Alani : " + dAlan);
}


static void Ucgen(){
    
    Console.Write("1.Kenari giriniz : ");
    int kenar1 = int.Parse(Console.ReadLine());
    Console.Write("2.Kenari giriniz : ");
    int kenar2 = int.Parse(Console.ReadLine());
    Console.Write("3.Kenari giriniz : ");
    int kenar3 = int.Parse(Console.ReadLine());
    int ucgenSecim = islem();
    switch(ucgenSecim){
        case 1:
            UcgenCevre(kenar1,kenar2,kenar3);
            break;
        case 2:
            UcgenAlan(kenar1,kenar2,kenar3);
            break;
        default:
            Console.WriteLine("Yanlis bir secim girdiniz");
            break;
    }

}

static void UcgenCevre(int k1, int k2, int k3){
    double uCevre=k1+k2+k3;
    Console.WriteLine("Ucgenin Cevresi : " + uCevre);
}

static void UcgenAlan(int k1, int k2, int k3){
    double s=(k1+k2+k3)/2.0;
    double uAlan=Math.Sqrt(s*(s-k1)*(s-k2)*(s-k3));
    Console.WriteLine("Ucgenin Alani : " + uAlan);
}


static void Kare(){
    
    Console.Write("Kenar giriniz : ");
    int kenar = int.Parse(Console.ReadLine());
    int kareSecim = islem();
    switch(kareSecim){
        case 1:
            KareCevre(kenar);
            break;
        case 2:
            KareAlan(kenar);
            break;
        default:
            Console.WriteLine("Yanlis bir secim girdiniz");
            break;
    }

}

static void KareCevre(int kenar){
    double kCevre=4*kenar;
    Console.WriteLine("Karenin Cevresi : " + kCevre);
}

static void KareAlan(int kenar){
    double kAlan=kenar*kenar;
    Console.WriteLine("Karenin Alani : " + kAlan);
}




static void Dikdortgen(){
    
    Console.Write("Uzun kenari giriniz : ");
    int ukenar = int.Parse(Console.ReadLine());
    Console.Write("Kisa Kenari giriniz : ");
    int kkenar = int.Parse(Console.ReadLine());
    int DikdortgenSecim = islem();
    switch(DikdortgenSecim){
        case 1:
            DikdortgenCevre(ukenar,kkenar);
            break;
        case 2:
            DikdortgenAlan(ukenar,kkenar);
            break;
        default:
            Console.WriteLine("Yanlis bir secim girdiniz");
            break;
    }

}

static void DikdortgenCevre(int ukenar, int kkenar){
    double dCevre=2*(ukenar+kkenar);
    Console.WriteLine("Dikdortgenin Cevresi : " + dCevre);
}

static void DikdortgenAlan(int ukenar, int kkenar){
    double dAlan=ukenar*kkenar;
    Console.WriteLine("Dikdortgenin Alani : " + dAlan);
}