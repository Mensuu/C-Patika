using System;

namespace DongulerForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar tek sayılarını ekrana yazdır.

            int sayac = int.Parse(Console.ReadLine());

            for (int i = 0; i <= sayac; i++)
            {
                if(i%2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            // 1 ile 1000 arasındaki tek ve çift sayıların kendi içlerindeki toplamlarını ekrana yazdır.

            int tekToplam = 0;

            int ciftToplam = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if(i % 2 == 1){
                    tekToplam+= i; // tekToplam = tektoplam + i;
                }
                else
                {
                    ciftToplam += i; // ciftToplam = cifttoplam + i;
                }
            }

            Console.WriteLine("Tek Toplam :" + tekToplam);

            Console.WriteLine("Çift Toplam :" + ciftToplam);

            // break, continue

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }
        }

        

       
    }
}