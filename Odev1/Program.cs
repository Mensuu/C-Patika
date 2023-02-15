using System;
namespace Odev1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1.Soru:Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            //2.SOru:Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin(n, m).Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            //3.Soru:Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            //4.Soru:Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            // 1.SORU

            Console.WriteLine("Pozitif bir sayı giriniz.");

            int diziUzunlugu = int.Parse(Console.ReadLine());

            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}.sayısını giriniz.", i + 1);

                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                int sayi = sayiDizisi[i];

                if (sayi % 2 == 0)
                {
                    Console.WriteLine("Çift Sayılar:");
                    Console.WriteLine(sayi);
                }
            }


            //// 2.SORU

            Console.WriteLine("Pozitif bir sayı giriniz.");

            int diziUzunlugu1 = int.Parse(Console.ReadLine());

            int[] sayiDizisi1 = new int[diziUzunlugu1];

            for (int i = 0; i < diziUzunlugu1; i++)
            {
                Console.WriteLine("Bölünen için {0}.sayıyı giriniz.", i + 1);

                sayiDizisi1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Bölen için pozitif ikinci bir sayı giriniz.");

            int bolen = int.Parse(Console.ReadLine());

            for (int i = 0; i < sayiDizisi1.Length; i++)
            {
                int sayi = sayiDizisi1[i];

                if (sayi % bolen == 0)
                {
                    Console.WriteLine("Kalansız Sayılar:");
                    Console.WriteLine(sayi);
                }
            }


            //3.SORU

            Console.WriteLine("Pozitif bir sayı giriniz.");

            int diziUzunlugu2 = int.Parse((Console.ReadLine()));

            string[] kelimeDizisi = new string[diziUzunlugu2];

            for (int i = 0; i < diziUzunlugu2; i++)
            {
                Console.WriteLine("Lütfen {0}.kelimeyi giriniz.", i + 1);

                kelimeDizisi[i] = Convert.ToString(Console.ReadLine());

            }
            
            foreach (var kelime in kelimeDizisi)
            {
                Array.Reverse(kelimeDizisi);
                Console.WriteLine(kelime);
            }

            //4.SORU

            Console.WriteLine("Bir cümle giriniz.");

            string cumle = Console.ReadLine();

            string[] kelimeDizisi1 = cumle.Split();

            Console.WriteLine("Kelime Sayısı :" + kelimeDizisi1.Length);

            Console.WriteLine("Harf Sayısı :" + cumle.Length);

        }





    }
}