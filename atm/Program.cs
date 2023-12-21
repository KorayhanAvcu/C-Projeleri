using System;
using System.Collections.Generic;

public static class Globals
{
    public static Dictionary<string, string> UserPassword = new Dictionary<string, string>();

    public static Dictionary<string, string> Admin = new Dictionary<string, string>();
    public static Dictionary<string, double> Account = new Dictionary<string, double>();
    public static Dictionary<int,string> Operations = new Dictionary<int, string>();
    public static int sayac = 1;
}

class Program
{
    static void Main()
    {
        
        Globals.UserPassword.Add("korayhan", "123");
        Globals.UserPassword.Add("deniz", "D2612");
        Globals.UserPassword.Add("elif", "2611");

        Globals.Admin.Add("Koray","123");
        Globals.Account.Add("korayhan", 3000);
        Globals.Account.Add("deniz", 5000);
        Globals.Account.Add("elif", 700);
        
        Baslangic();
        
        
    }
    static void Baslangic(){
        Console.WriteLine("1.Gun Sonunu Gor\n2.Uye Girisi\nSeciminiz: ");
        int secim = int.Parse(Console.ReadLine());
        if(secim==1)
            GunSonuGoster();
            UyeGirisi();
    }
    static void AnaSayfa(string user){
        double bakiye=0;
        if(Globals.Account.ContainsKey(user)){
            /* Console.WriteLine($"{user} hosgeldiniz!"); */
            bakiye = Globals.Account[user];
            Console.WriteLine($"Hesap Bakiyeniz : {bakiye}");
            Console.Write("Cekmek İstediginiz Tutari Giriniz: ");
            Console.Write("\n1. Para Cekme\n2. Para Yatirma\n3. Odeme Yapma\n4. Cikis\nSeciminiz: ");
            int secim = int.Parse(Console.ReadLine());

            if (secim == 1)
            {
                ParaCekme(user);
            }
             else if(secim == 2)
            {
                ParaYatirma(user);
                
            }
            else if(secim == 3){
                OdemeYapma(user);
            }
            else if(secim == 4){
                Cikis();
            }
            else{
                Console.WriteLine("Yanlis bir giris talebinde bulundunuz.");
                AnaSayfa(user);
            }
        }
        
        
    }
    static void Cikis(){
        Baslangic();
    }
        
    static void ParaCekme(string user){
        double bakiye=0;
        if(Globals.Account.ContainsKey(user)){
            bakiye = Globals.Account[user];
            Console.Write("Cekmek İstediginiz Tutari Giriniz: ");
            string cekilecekBakiye=Console.ReadLine();
            if (double.TryParse(cekilecekBakiye, out double number))
            {
                Console.WriteLine($"Dönüştürülen sayı: {number}");
                if(number>bakiye){
                    Console.WriteLine("Yeterli Bakiye Yok!");
                    ParaCekme(user);
                }
                else{
                    Globals.Account[user]=bakiye-number;
                    string islem = $"{user} kisisi tarafindan {number} tutarinda para cekme islemi yapildi.";
                    GunSonu(islem);
                    AnaSayfa(user);
                }
            }
            else
            {
                Console.WriteLine("Lutfen Uygun Bir Deger Girin.");
            }

        }
    }
    static void ParaYatirma(string user){
        double bakiye=0;
        if(Globals.Account.ContainsKey(user)){
            bakiye = Globals.Account[user];
            Console.Write("Yatirmak İstediginiz Tutari Giriniz: ");
            string cekilecekBakiye=Console.ReadLine();
            if (double.TryParse(cekilecekBakiye, out double number))
            {
            
                Globals.Account[user]=bakiye+number;
                string islem = $"{user} kisisi tarafindan {number} tutarinda para yatırma islemi yapildi.";
                GunSonu(islem);
                AnaSayfa(user);
            }
            else
            {
                Console.WriteLine("Lutfen Uygun Bir Deger Girin.");
            }

        }
    }
    static void OdemeYapma(string user){
        Console.Write("1. Kredi Karti Odeme\n2. Fatura Odeme\n3. Transfer Yapma\nSeciminiz : ");
        int secim = int.Parse(Console.ReadLine());
        if(secim==1){
            KrediKartiOdeme(user);
        }
        else if(secim==2){
            FaturaOdeme(user);
        }
        else if(secim==3){
            Transfer(user);
        }
    }
    static void KrediKartiOdeme(string user){
        double bakiye=0;
        if(Globals.Account.ContainsKey(user)){
            bakiye = Globals.Account[user];
            Console.Write("Odeme Yapilacak Tutari Giriniz :  ");
            string cekilecekBakiye=Console.ReadLine();
            if (double.TryParse(cekilecekBakiye, out double number))
            {
                
                if(number>bakiye){
                    Console.WriteLine("Yeterli Bakiye Yok!");
                    ParaCekme(user);
                }
                else{
                    Globals.Account[user]=bakiye-number;
                    string islem = $"{user} kisisi tarafindan {number} tutarinda kredi karti odemesi islemi yapildi.";
                    GunSonu(islem);
                    AnaSayfa(user);
                }
            }
            else
            {
                Console.WriteLine("Lutfen Uygun Bir Deger Girin.");
            }

        }
    }
    static void FaturaOdeme(string user){
        double bakiye=0;
        if(Globals.Account.ContainsKey(user)){
            bakiye = Globals.Account[user];
            Console.Write("Odenilecek Fatura Tutari Giriniz: ");
            string cekilecekBakiye=Console.ReadLine();
            if (double.TryParse(cekilecekBakiye, out double number))
            {
                
                if(number>bakiye){
                    Console.WriteLine("Yeterli Bakiye Yok!");
                    ParaCekme(user);
                }
                else{
                    Globals.Account[user]=bakiye-number;
                    string islem = $"{user} kisisi tarafindan {number} tutarinda fatura odeme islemi yapildi.";
                    GunSonu(islem);
                    AnaSayfa(user);
                }
            }
            else
            {
                Console.WriteLine("Lutfen Uygun Bir Deger Girin.");
            }

        }
    }
    static void Transfer(string user){
        double bakiye=0;
        if(Globals.Account.ContainsKey(user)){
            bakiye = Globals.Account[user];
            Console.Write("Transfer Tutarini Giriniz: ");
            string cekilecekBakiye=Console.ReadLine();
            if (double.TryParse(cekilecekBakiye, out double number))
            {
                Console.WriteLine($"Dönüştürülen sayı: {number}");
                if(number>bakiye){
                    Console.WriteLine("Yeterli Bakiye Yok!");
                    ParaCekme(user);
                }
                else{
                    Globals.Account[user]=bakiye-number;
                    string islem = $"{user} kisisi tarafindan {number} tutarinda para transfer islemi yapildi.";
                    GunSonu(islem);
                    AnaSayfa(user);
                }
            }
            else
            {
                Console.WriteLine("Lutfen Uygun Bir Deger Girin.");
            }

        }
    }
    
    static void UyeGirisi()
    {
        Console.Write("Kullanici adinizi giriniz : ");
        string user = Console.ReadLine();
        Console.Write("Sifrenizi giriniz : ");
        string inputPassword = Console.ReadLine();

        if (Globals.UserPassword.ContainsKey(user))
        {
            string password = Globals.UserPassword[user];

            if (password == inputPassword)
            {
                Console.WriteLine("Giris Basarili\n");
                AnaSayfa(user);
                
            }
            else
            {
                Console.WriteLine("Sifreniz Yanlistir");
                string islem = $"{user} kisisi tarafindan hatali giris islemi yapildi.";
                GunSonu(islem);
                UyeGirisi();
            }
        }
        else
        {
            Console.WriteLine("Kullanici adi yanlis veya eksik girilmistir.");
            string islem = $"Hatali giris islemi yapildi.";
            GunSonu(islem);
            UyeGirisi();
        }
    }
    static void GunSonu(string data){
        string tarih = DateTime.Now.ToString("ddMMyyyy");

        string dosyaAdi = $"EOD_{tarih}.txt";
        try
        {
            if (!File.Exists(dosyaAdi))
            {
                
                using (StreamWriter dosya = new StreamWriter(dosyaAdi, false))
                {
                    dosya.WriteLine(data);
                }

            }
            else
            {
                
                using (StreamWriter dosya = File.AppendText(dosyaAdi))
                {
                    dosya.WriteLine(data);
                }
            }

            Console.WriteLine($"Yeni veri başarıyla dosyaya eklendi: {dosyaAdi}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Dosya işlem hatası: {ex.Message}");
        }
    }
    static void GunSonuGoster(){
        string tarih = DateTime.Now.ToString("ddMMyyyy");

        string dosyaAdi = $"EOD_{tarih}.txt";
        try
        {
            if (File.Exists(dosyaAdi))
            {
                Console.WriteLine($"{tarih} Gun Sonu Raporu");
                using (StreamReader sr = new StreamReader(dosyaAdi))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine($"Dosya bulunamadı: {dosyaAdi}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Bir hata oluştu: " + ex.Message);
        }
    }
}
