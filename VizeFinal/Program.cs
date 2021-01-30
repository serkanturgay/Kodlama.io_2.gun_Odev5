using System;

namespace VizeFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int vize = 0;
            int final = 0;
            Console.WriteLine("Vize Notunuzu Giriniz:");
            vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final Notunuzu Giriniz:");
            final = Convert.ToInt32(Console.ReadLine());

            int Ortalama = (vize * 4 / 10) + (final * 6 / 10);

            Console.WriteLine(Ortalama);

            
        }
    }
}
