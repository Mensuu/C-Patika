using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            string kelime = "Menekşe";
            Console.WriteLine(kelime);

            // Veri Tipleri

            byte b = 5;
            sbyte sb = 5;
            short s = 5;
            ushort us = 5;

            Int16 i16 = 2;
            int i = 2;
            Int32 i32 = 2;
            Int64 i64 = 2;
            uint ui = 2;
            long l = 2;
            ulong ul = 2;

            float f = 5;
            double d = 5;
                
            char c = 'a';
            string str = "hello";

            bool bl = true;

            DateTime dateTime= DateTime.Now;
            Console.WriteLine(dateTime.ToString());

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4.5;
            object o4 = 6;

            string str1 = string.Empty;
            string str2 = null;
            string str3;

            string strName = "Menekşe Çorum";
            string name = "Menekşe";
            string surname = "Çorum";
            string fullname = name + " " + surname;

            Console.WriteLine(fullname);
            Console.WriteLine(strName);

            int int1 = 5;
            int int2 = 3;
            int int3 = int1 * int2;

            bool b1 = 10 > 2;

            string str20 = "20";
            int int20 = 20;
            string str22 = str20+ "" + int20.ToString();

            Console.WriteLine(str22);

            int int22 = int20 + Convert.ToInt32(str20);

            Console.WriteLine(int22);

            int int4 = int20 + int.Parse(str20);

            Console.WriteLine(int4);

            string datetime1 = DateTime.Now.ToString("dd.MM.yyyy");

            Console.WriteLine(datetime1);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");

            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");

            Console.WriteLine(hour);

            Console.ReadLine();

            string t1est = "test";




        }
    }
}

