using System;

namespace OtoparkOtomat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kac Saat Otoparkta Kaldiniz:");
            int otoparkSure = Convert.ToInt32(Console.ReadLine());
            if (otoparkSure<=0)
            {
                Console.WriteLine("LUTFEN GECERLI SAYI GIRINIZ.");
            }
            else if (otoparkSure<=3)
            {
                Console.WriteLine("UCRET : 4TL");
            }
            else if(otoparkSure>3 && otoparkSure<=7)
            {
                Console.WriteLine("UCRET : 3TL");
            }
            else if(otoparkSure>7 && otoparkSure<=12)
            {
                Console.WriteLine("UCRET : 2TL");
            }
            else
            {
                Console.WriteLine("UCRET : 1TL");
            }

        }
    }
}
