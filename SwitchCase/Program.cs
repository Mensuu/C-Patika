using System;

class SwitchCase
{
    static void Main(string[] args)
    {
        int mount = DateTime.Now.Month;

        switch(mount)
        {
            case 1:
                Console.WriteLine("Ocak ayındasınız!");
                break;

            case 2:
                Console.WriteLine("Şubat ayındasınız!");
                break;

            case 3:
                Console.WriteLine("Mart ayındasınız!");
                break;

            case 4:
                Console.WriteLine("Nisan ayındasınız!");
                break;
            default:
                Console.WriteLine("Yanlış veri girdiniz.");
                break;
        }
        switch(mount)
        {
            case 12:

            case 2:

            case 1:

                Console.WriteLine("Kış ayındasınız!");

            break;

            case 3:

            case 4:

            case 5:

                Console.WriteLine("İlkbahar ayındasınız!");

                break;
            case 6:

            case 7:

            case 8:

                Console.WriteLine("Yaz ayındasınız!");

                break;
            case 9:

            case 10:

            case 11:

                Console.WriteLine("Sonbahar ayındasınız!");

                break;

            default:
            break;
        }
    }
}