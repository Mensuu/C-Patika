using System;

namespace HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Try catch blokları sayesinde uygulama içerisinde bir hata oluştuğunda belirtilen işlemler yaptırılabilir.
            try{ Hataya sebebiyet verme ihtimali olan kod }
            catch { Hata ile karşılaşıldığında ne yapılacağı buraya yazılır }
            finally{ Hata olsun olmasın mutlaka yapılmasını istediğimiz işler varsa buraya yazarız }*/

            try
            {
                Console.WriteLine("Bir sayı giriniz!");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girdiğiniz Sayi: " + sayi);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            try
            {
                int a = int.Parse("Test");
            }
            catch (ArgumentNullException ex)
            {

                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {

                Console.WriteLine("Veri tipiniz uygun değil.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {

                Console.WriteLine("Çok büyük yada küçük değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlanmıştır.");
            }

        }
    }
}