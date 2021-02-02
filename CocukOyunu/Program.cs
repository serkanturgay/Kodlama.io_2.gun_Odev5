using System;

namespace CocukOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lutfen Yas Giriniz : ");
            int yas = Convert.ToInt32(Console.ReadLine());
            if (yas<7 & yas>3)
            {
                Console.WriteLine("0-100 arasi bir oyun secebilirsiniz.");
                int yasKucuk = Convert.ToInt32(Console.ReadLine());
                if (yasKucuk>0 & yasKucuk<=100)
                {
                    Console.WriteLine(yasKucuk + "  Numarali oyunu sectiniz.");
                }
                else
                {
                    Console.WriteLine("Lutfen gecerli bir sayi giriniz.");

                }
            }
            else if(yas>=7 & yas<12)
            {
                Console.WriteLine("100-500 arasi bir oyun secebilirsiniz.");
                int yasOrta = Convert.ToInt32(Console.ReadLine());
                if (yasOrta > 100 & yasOrta <= 500)
                {
                    Console.WriteLine(yasOrta + "  Numarali oyunu sectiniz.");
                }
                else
                {
                    Console.WriteLine("Lutfen gecerli bir sayi giriniz.");

                }
            }
            else if(yas >= 12 & yas <= 15)
            {
                Console.WriteLine("500-1000 arasi bir oyun secebilirsiniz.");
                int yasBuyuk = Convert.ToInt32(Console.ReadLine());
                if (yasBuyuk > 500 & yasBuyuk <= 1000)
                {
                    Console.WriteLine(yasBuyuk + "  Numarali oyunu sectiniz.");
                }
                else
                {
                    Console.WriteLine("Lutfen gecerli bir sayi giriniz.");

                }

            }
            else
            {
                Console.WriteLine("Lutfen gecerli bir yas giriniz.");
            }
        }
    }
}
