using System;


namespace TahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random sayi = new Random();
                int rastgele = sayi.Next(0, 10);
                Console.WriteLine("Tahmininizi giriniz.");
                int tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin == rastgele)
                {
                    Console.WriteLine("Tebrikler");
                    break;
                }
                else
                {
                    Console.WriteLine("dogru sayi : " + rastgele);


                }
            }
        }
            
    }
}
