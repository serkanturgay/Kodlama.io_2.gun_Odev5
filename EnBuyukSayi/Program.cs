using System;

namespace BuyuktenKucuge
{
    class Program
    {
        static void Main(string[] args)
        {
            int enBuyukSayi = 0;//karsilastirmadan sonra en buyuk sayiyi tutan degisken.
            int kacSayi = 0;
            Console.WriteLine("Kac Sayi Karsilastirilacak"); //Kullanicidan kac sayi olacagini istiyoruz.
            kacSayi = Convert.ToInt32(Console.ReadLine());//girilen sayi integer`a cevriliyor
            int[] sayilar = new int[kacSayi];//kullanicidan istenen sayi kadar array tanimlaniyor.

            for (int i = 0; i < kacSayi; i++)//kullanicidan sayilar isteniyor.
            {
                Console.WriteLine(i + 1 + ". sayiyi giriniz");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < kacSayi; i++)//en buyuk sayiyi bulmak icin arraydeki her bir eleman karsilastiriliyor.
            {

                if (sayilar[i] > enBuyukSayi)
                {
                    enBuyukSayi = sayilar[i];
                }
            }
            Console.WriteLine(enBuyukSayi);//en buyuk sayi ekrana yazdiriliyor.
        }
    }
}
