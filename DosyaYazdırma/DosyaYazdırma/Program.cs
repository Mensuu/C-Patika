namespace DosyaYazdırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileInfoKullanımı();

        }
        private static void FileInfoKullanımı()
        {
            FileInfo FI = new FileInfo(@"C:\PinarYasan\pnr.txt");


            DirectoryInfo DI = FI.Directory;//Bulunduğu klasör.
            FileInfo[] DirectoryInfoList = DI.GetFiles();//dosyanın bulunduğu klasördeki dosyaların listesi.

            Console.WriteLine("Dosya Olusturma Zamani : " + FI.CreationTime.ToString("dd.MM.yyyy hh:ss"));
            Console.WriteLine("Tam Yol Bilgisi : " + FI.FullName);
            Console.WriteLine("Dosya Uzantisi : " + FI.Extension);
            Console.WriteLine("Byte Uzunluk : " + FI.Length.ToString());
            Console.WriteLine("Dosya Adi : " + FI.Name);
            Console.WriteLine("Klasor Adi : " + FI.DirectoryName);
            foreach (var item in DI.GetFiles())
            {
                Console.WriteLine("Klasör --> " + FI.DirectoryName + " - Dosya Adi -->" + item.Name);
            }

            Console.ReadLine();

        }
    }
}