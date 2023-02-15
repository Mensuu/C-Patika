using System;

namespace odev_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddMinutes(3));
            Console.WriteLine(DateTime.Now.AddSeconds(32));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(1));

            //DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));//ayın günü
            Console.WriteLine(DateTime.Now.ToString("ddd"));//günün kısaltması
            Console.WriteLine(DateTime.Now.ToString("dddd"));//günü

            Console.WriteLine(DateTime.Now.ToString("MM"));//ay
            Console.WriteLine(DateTime.Now.ToString("MMM"));//ay kıslttma
            Console.WriteLine(DateTime.Now.ToString("MMMM"));// ayın adı

            Console.WriteLine(DateTime.Now.ToString("yy"));//21
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//2021


            // Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25));//Mutlak Değer
            Console.WriteLine(Math.Sin(10));//sin alır
            Console.WriteLine(Math.Cos(10));//cos alır
            Console.WriteLine(Math.Tan(10));//tan alır


            Console.WriteLine(Math.Ceiling(22.3));//Yukarı yuvarlar 23
            Console.WriteLine(Math.Round(22.8));//En yakın değere yuvarlar 23
            Console.WriteLine(Math.Floor(22.7));//Aşağı yuvarlar 22 

            Console.WriteLine(Math.Min(2, 6));
            Console.WriteLine(Math.Max(2, 6));

            Console.WriteLine(Math.Pow(3, 4));//3^4
            Console.WriteLine(Math.Sqrt(9));//9^-2
            Console.WriteLine(Math.Log(9));//ln9
            Console.WriteLine(Math.Exp(3));//e^3
            Console.WriteLine(Math.Log10(10));//log10(10)
        }
    }
}