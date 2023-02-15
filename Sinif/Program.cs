nusing System;

namespace Sinif
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz dizimi
            //    class SinifAdi
            //{
            //    [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
            //    [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi]);
            //    {
            //      Metot Komutları
            //    }
            //}

            // Erişim Belirleyiciler
            // * Public
            // * Private
            // * Internal
            // * Protected

            Calisan calisan1 = new Calisan();
            calisan1.No = 1;
            calisan1.Adi = "Menekşe";
            calisan1.Soyad = "Çorum";
            calisan1.Departman = "IK";
            calisan1.CalisanBilgileri();

            Console.WriteLine();

            Calisan calisan2 = new Calisan();
            calisan2.No = 2;
            calisan2.Adi = "Demet";
            calisan2.Soyad = "Kaya";
            calisan2.Departman = "IT";
            calisan2.CalisanBilgileri();

        }

        class Calisan
        {
            public int No { get; set; }
            public string Adi { get; set; }
            public string Soyad { get; set; }
            public string Departman { get; set; }

            public void CalisanBilgileri()
            {
                Console.WriteLine("Çalışan Numarası:{0}", No);
                Console.WriteLine("Çalışan Adı:{0}", Adi);
                Console.WriteLine("Çalışan Soyadı:{0}", Soyad);
                Console.WriteLine("Çalışanın Departmanı:{0}", Departman);

            }
        }
    }
}