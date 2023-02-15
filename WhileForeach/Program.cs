using System;

namespace WhileForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While");
            // 1 den başlayarak konsoldan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp consola yazdıran program.
            Console.WriteLine("Bir sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac  ++;
            }

            Console.WriteLine(toplam / sayi);

            // 'a' dan 'z' ye kadar tüm harfleri console a yazdır.

            char character = 'a';

            while (character < 'z')
            {
                Console.WriteLine(character);
                character++;
            }

            Console.WriteLine("Foreach");

            string[] arabalar = { "BMW", "Ford", "Nissan" };


            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

        }

    }

}