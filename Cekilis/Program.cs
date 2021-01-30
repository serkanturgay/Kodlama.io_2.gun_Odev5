using System;

namespace Cekilis
{
    class Program
    {
        static void Main(string[] args)
        {
            int k=0;
            string kisi;
            Console.WriteLine("Cekilis Kisi Sayisi");
            k = Convert.ToInt32(Console.ReadLine());
            string[] kisiler = new string[k];

            for (int i = 0; i < k; i++)
            {
                kisi = Console.ReadLine();
                kisiler[i] = kisi;
                
            }

            Console.WriteLine("Cekilis Yapiliyor Lutfen Bekleyin.");
            Console.WriteLine("---------------------------------");
            System.Threading.Thread.Sleep(3000);
            Random random = new Random();
            int sayi = random.Next(0, kisiler.Length);
            Console.WriteLine("Kazanan : " + kisiler[sayi]);
        }
    }
}
