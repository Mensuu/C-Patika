﻿using System;
namespace metotOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if(sonuc) 
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız!");
            }

            Metot instance= new Metot();
            instance.Topla(4, 5, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            //Metot Aşırı Yükleme = Overloading

            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Menekşe", "Çorum");

            //Metot İmzası
            //metotAdi + parametre sayisi + parametre
        }
    }

    class Metot
    {
        public void Topla( int a , int b , out int toplam)
        {
            toplam = a + b;
            
        }
        
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }

    }
}