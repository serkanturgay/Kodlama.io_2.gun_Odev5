using System;

namespace MutlakSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayiyi Giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a<0)
            {
                a = a * (-1);
                Console.WriteLine("Girdiginiz sayinin mutlak degeri : " + a);
            }
            else
            {
                Console.WriteLine("Girdiginiz sayinin mutlak degeri : " + a);
            }
        }
    }
}
