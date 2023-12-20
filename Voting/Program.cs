using System;
using System.Collections.Generic;

public static class Globals
{
    public static Dictionary<string, string> UserPassword = new Dictionary<string, string>();
    public static Dictionary<string, int> CategoryScore = new Dictionary<string, int>();
    public static Dictionary<string,string> UsedUsers = new Dictionary<string, string>();
}

class Program
{
    static void Main()
    {
        
        Globals.UserPassword.Add("korayhan", "123");
        Globals.UserPassword.Add("deniz", "D2612");
        Globals.UserPassword.Add("elif", "2611");

        Globals.CategoryScore.Add("Film", 0);
        Globals.CategoryScore.Add("Tech Stack", 0);
        Globals.CategoryScore.Add("Spor", 0);

        foreach (var item in Globals.UsedUsers)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        } 
        AnaSayfa();
        
    }
    static void AnaSayfa(){
        Console.Write("\n1. Uye Girisi\n2. Kayit Ol\n3. Oy Durumunu Gor.\nSeciminiz: ");
        int secim = int.Parse(Console.ReadLine());

        if (secim == 1)
        {
            UyeGirisi();
        }
        else if(secim == 2)
        {
            UyeKayit();
            UyeGirisi();
        }
        else if(secim == 3){
            ShowScore();
        }
        else{
            Console.WriteLine("Yanlis bir giris talebinde bulundunuz.");
        }
    }
    static void UyeKayit()
    {
        Console.Write("Kullanici Adi Giriniz: ");
        string user = Console.ReadLine();
        Console.Write("Sifre: ");
        string password = Console.ReadLine();

        if (Globals.UserPassword.ContainsKey(user))
        {
            Console.WriteLine("Kullanici adi kullanilmaktadir.");
            UyeKayit();
        }
        else
        {
            Globals.UserPassword.Add(user, password);
            Console.WriteLine("Kaydiniz Basarili");
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
                if(Globals.UsedUsers.ContainsKey(user)){
                    Console.WriteLine("Oy kullandiniz.");
                }
                else{
                    OyKullan(user);
                    ShowScore();
                }
                
            }
            else
            {
                Console.WriteLine("Sifreniz Yanlistir");
                UyeGirisi();
            }
        }
        else
        {
            Console.WriteLine("Kullanici adi yanlis veya eksik girilmistir.");
            UyeGirisi();
        }
    }
    static void OyKullan(string user){
        int count = 0;
        string[] category= new string[Globals.CategoryScore.Count];
        foreach (var item in Globals.CategoryScore)
        {
            category[count] = item.Key;
            count++;
        }
        Show();
        Console.Write("Seciminiz : ");
        int select = int.Parse(Console.ReadLine());
        string categorySelected = category[select-1];
        if(Globals.CategoryScore.ContainsKey(categorySelected)){
            int score = 1;
            score+=Globals.CategoryScore[categorySelected];
            Globals.CategoryScore[categorySelected]=score;
            Globals.UsedUsers.Add(user,categorySelected);
        }
        Console.WriteLine("Oyunuz basarili bir sekilde kullanildi.");
        ShowScore();
        AnaSayfa();
        
        
    }
    static void Show(){
        int count = 0;
        Console.WriteLine("\nKategorilerden Birisine Oyunuzu Veriniz!\n");
        foreach (var item in Globals.CategoryScore)
        {
            Console.WriteLine((count+1) + ". " + item.Key);
            count++;
        }
        
    }
    static void ShowScore(){
        int count = 0;
        Console.WriteLine("Oylarin Son Durumlari");
        foreach (var item in Globals.CategoryScore)
        {
            Console.WriteLine((count+1) + ". " + item.Key + "Alinan Oy Sayisi : " + item.Value + " Yuzdesi : " + (((double)item.Value/Globals.UsedUsers.Count)*100));
            count++;
        }
    }
}
