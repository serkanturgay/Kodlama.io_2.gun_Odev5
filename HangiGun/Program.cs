using System;

namespace HangiGun
{
    class Program
    {
        static void Main(string[] args)
        {
            int girilenSayi=0;
            Console.WriteLine("Gun Giriniz");
            girilenSayi = Convert.ToInt32(Console.ReadLine());
            string[] gunler = new string[] { "Pazartesi", "Sali","Carsamba","Persembe","Cuma","Cumartesi","Pazar" };

            Console.WriteLine(gunler[girilenSayi-1]);


        }
    }
}
