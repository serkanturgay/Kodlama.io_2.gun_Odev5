using System;

namespace OzelSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp_i; //gecici i sayisi (bu olmasa da olurdu ; ama kod guzel duruyor diye silmedim.)
            for (int i = 1; i < 10000; i++)
            {
                temp_i = Math.Sqrt(i*i*2 - 1);//kok [(i^2-1)-1]
                temp_i = temp_i * 10; //10 katini alip mod 10 u 0 ise tam sayidir.

                if (temp_i % 10 == 0)//mod 10 esit mi 0
                {
                    Console.WriteLine(i);
                }
               

            }
        }
    }
}
