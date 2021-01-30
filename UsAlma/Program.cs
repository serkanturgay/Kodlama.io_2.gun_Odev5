using System;

namespace UsAlma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayiyi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ust giriniz");
            int ust = Convert.ToInt32(Console.ReadLine());
            int sonuc = 1;
            for (int i = 1; i < ust+1; i++)
            {

                sonuc = sonuc * sayi;
            }
            Console.WriteLine(sonuc);
        }

    }
}
