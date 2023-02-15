using System;
using System.Collections.Generic;

namespace Generic_Koleksiyonlar_ve_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collection.Generic
            //T->Generic olduğunu söyler.Object türündedir. Nesne alabilir.

            //Listenin içerisindeki nesnelerin tipini ifade ediyor.Hangi tipten oluşan bir nesne ekleyeceğim ben buraya bunu T ile belirtiyo olmam gerekiyor.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count->Eleman sayısı

            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //ekrana yazdırma Foreach ve List.Foreach ile elemanlara erişim

            foreach (var item in sayiListesi)
            {
                Console.WriteLine(item);
            }

            foreach (var item in renkListesi)
            {
                Console.WriteLine(item);
            }

            //List.Foreach ile ekrana yazdırma elemanlara erişim

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden index ile eleman çıkarma

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içerisinde arama
            //Bu Liste içerisinde parantez içerisinde yazmış olduğumuz değeri arar
            //Eğer bulursan git 10 lisete içerisinde bulundu yaz.

            if (sayiListesi.Contains(10)) ;
            {
                Console.WriteLine("10 Liste içerisinde bulundu");
            }

            //Elaman ile o elemanın indexine erişme
            //BinarySearch ile bunu yapabilirim.

            Console.WriteLine(renkListesi.BinarySearch("Kırmızı"));

            //Diziyi List'e çevirme

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };

            //hayvanlar dizisini gidip hayvanListesi adında bir listeye çevirir.

            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi nasıl temizleriz ?

            hayvanListesi.Clear();

            //Liste içerisinde nesne tutmak istiyorsam class

            List<kullanıcılar> kullanıcıListesi = new List<kullanıcılar>();

            kullanıcılar kullanıcı1 = new kullanıcılar();

            kullanıcı1.Isim = "Ayşe";
            kullanıcı1.Soyisim = "Yılmaz";
            kullanıcı1.Yas = 26;

            kullanıcılar kullanıcı2 = new kullanıcılar();

            kullanıcı2.Isim = "Özcan";
            kullanıcı2.Soyisim = "Çalışkan";
            kullanıcı2.Yas = 26;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<kullanıcılar> yeniListe = new List<kullanıcılar>();
            yeniListe.Add(new kullanıcılar()
            {
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 24
            });
            // kullanıcılar sınıfının elemanlarına erişme

            foreach (var item in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı:" + item.Isim);
                Console.WriteLine("Kullanıcı Adı:" + item.Soyisim);
                Console.WriteLine("Kullanıcı Adı:" + item.Yas);
            }




        }
    }

    public class kullanıcılar
    {

        //Bunlar private olur dışarıya açılmaz sadece bu class içinde kullanılır.
        string isim;

        string soyisim;

        int yas;

        //Bunlar public dışarıya açık diğer classlar içinde kullanılabilir.

        public string Isim { get => isim; set => isim = value; }

        public string Soyisim { get => soyisim; set => soyisim = value; }

        public int Yas { get => yas; set => yas = value; }



    }
}