using System;

namespace AlısKar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Urunun maliyetini giriniz : ");
            int maliyet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kar orani giriniz : ");
            int kar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Satis Fiyati : " + (maliyet+maliyet*kar/100));


        }
    }
}
