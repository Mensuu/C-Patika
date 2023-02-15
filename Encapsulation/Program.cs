using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci("Ayşe", "Yılmaz", 293, 3);
            ogrenci1.OgrenciBilgileriniGetir();

            ogrenci1.SinifAtlat();

            ogrenci1.OgrenciBilgileriniGetir();

            Ogrenci ogrenci2 = new Ogrenci("Menekşe", "Çorum", 683, 1);

            ogrenci2.Dusur();
            ogrenci2.Dusur();

            ogrenci2.OgrenciBilgileriniGetir();

        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif
        {
            get => sinif;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olmalıdır!");
                    sinif = 1;
                }
                else
                    sinif = value;
            }
        }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public Ogrenci() { }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("---------- Öğrenci Bilgileri ----------");
            Console.WriteLine("Öğrenci Adı         :{0}", this.Isim);
            Console.WriteLine("Öğrenci Soyadı      :{0}", this.Soyisim);
            Console.WriteLine("Öğrenci Numarası    :{0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı      :{0}", this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif++;
        }

        public void Dusur()
        {
            this.Sinif--;
        }
    }
}