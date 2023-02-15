
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

namespace hesapMakinesi
{

    public class dortislem
        {

            // private int a, b;

            public int carpma(int a, int b)  //method
            {
                // hesap makinesi çarpma işleminin sonucu
                return a * b;
            }

            public int topla(int a, int b)
            {
                // hesap makinesi toplama işleminin sonucu
                return a + b;
            }

            public int bolme(int a, int b)
            {
                // hesap makinesi bölme işleminin sonucu
                return a / b;
            }

            public int cikar(int a, int b)
            {
                // hesap makinesi çıkarma işleminin sonucu
                return a - b;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                //a:birinci sayı,b:ikinci sayı, c : işlemin sonucu olsun.
                int a, b, c;
                bool devam = true;
                //dörtislem sınıfından bir tane örnek alınarak bu sınıfta bulunan işlemler yapılabilir.
                dortislem islem = new();


                //devam ile işlem programdan çıkıncata kadar tekrarlanabilir
                while (devam)
                {
                    Console.WriteLine();

                    Console.WriteLine("Yeni islem ==>");

                    Console.Write("a = ");

                    a = Convert.ToInt16(Console.ReadLine());

                    Console.Write("b = ");

                    b = Convert.ToInt16(Console.ReadLine());

                    // Hesap makinesi ile hangi işlemi yapmak istediğinizi giriniz
                    Console.WriteLine("bolme->1,carpma->2,cıkarma->3,toplama->4, hepsi->5,yeni sayi gir->6, cıkıs->0");
                    // Hesap makinesi ile  yapılmak istenen işlem veya işlemler c değişkenine kaydeder
                    c = Convert.ToInt16(Console.ReadLine());

                    //Eğer Hesap makinesi nden çıkılmak isteniyorsa döngüden çıkmak için devam false yapılır
                    if (c == 0)
                        devam = false;
                    // Hesap makinesi işlemlerinden biri seçilmiş ise hesap makinesi bu işlemi yapar.
                    if (c <= 5)
                    {
                        if (c == 2 || c == 5)
                            // hesap makinesi çarpma işlemi
                            //sonuç işlem sınıfının çarpma işleminin sonucuna eşit olacak
                            Console.WriteLine("a * b = " + islem.carpma(a, b));
                        if (c == 1 || c == 5)
                            // hesap makinesi bölme işlemi
                            //sonuç işlem sınıfının bölme işleminin sonucuna eşit olacak
                            Console.WriteLine("a / b = " + islem.bolme(a, b));
                        if (c == 3 || c == 5)
                            // hesap makinesi  çıkarma işlemi 
                            //sonuç işlem sınıfının çıkarma işlemininin sonucuna eşit olacak
                            Console.WriteLine("a - b = " + islem.cikar(a, b));
                        //if (c == 4 || c == 5)
                        //    // hesap makinesi  toplama işlemi
                        //    Console.WriteLine("a + b = " + islem.topla(a, b));

                        //yukarıdaki islem ile bu  işlem aynı sonucu verir.
                        if (c == 4 || c == 5)
                            // hesap makinesi  toplama işlemi
                            //sonuç işlem sınıfının toplama işleminin sonucuna eşit olacak
                            Console.WriteLine("a + b = {0}", islem.topla(a, b));
                    }
                }
            }
        }
    }
