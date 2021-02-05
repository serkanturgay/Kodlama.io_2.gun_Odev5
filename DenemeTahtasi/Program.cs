using DenemeTahtasi;
using System;

class Program
{

    static void Main()
    {
        MyList<string> isimler = new MyList<string>();
        isimler.Add("Serkan") ;
        Console.WriteLine(isimler.Lenght);
        isimler.Add("Ahmet");
        Console.WriteLine(isimler.Lenght);
        foreach (string isim in isimler.arrays)
        {
            Console.WriteLine(isim);
        }

    }
}