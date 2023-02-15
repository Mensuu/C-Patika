using System;

namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion (Bilinçsiz dönüşüm)

            // Düşük kapasiteli bir değişkenin daha yüksek kapasiteli bir değişkene dönüşmesi.
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine(d);

            long h = d;
            Console.WriteLine(h);

            float i = h;
            Console.WriteLine(i);

            string s = "Menekse";
            char r = 'k';
            object g = s + r + d;
            Console.WriteLine(g);



            //Explicit conversion (Bilinçli Dönüşüm)

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine(y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine(t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine(v);

            // ToString Metodu

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine(yy);

            string zz = 12.5f.ToString();
            Console.WriteLine(zz);

            //System.Convert

            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int Toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            Toplam = sayi1 + sayi2;
            Console.WriteLine(Toplam);


            // Parse string ifadeleri dönüştürmek için kullanılır.

            ParseMethod();
        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;
            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            Console.WriteLine(rakam1);
            Console.WriteLine(double1);
        }
    }
}