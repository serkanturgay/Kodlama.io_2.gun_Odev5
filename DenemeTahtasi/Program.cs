using System;

class Program
{

    static void Main()
    {

        string girilenSayi = "1453";
        int sayimiz;

        bool sonuc = int.TryParse(girilenSayi, out sayimiz);

        if (sonuc)
        {
            Console.WriteLine("Dönüşüm başarılı.");
            Console.WriteLine("Sayı: {0}", sayimiz);
        }
        else
        {
            Console.WriteLine("Dönüşüm başarısız.");
        }
    }
}