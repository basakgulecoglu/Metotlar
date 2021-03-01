using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.UrununAdi = "Elma";
            urun1.Aciklamasi = "güzel";
            urun1.Fiyati = 10;

            Product urun2 = new Product();
            urun2.UrununAdi = "karpuz";
            urun2.Fiyati = 55;
            urun2.Aciklamasi = "kütür kütür";

            Product[] urunler = new Product[] { urun2, urun1 };

            foreach(Product urun in urunler)
            {
                Console.WriteLine(urun.Aciklamasi);
                Console.WriteLine(urun.UrununAdi);
                Console.WriteLine(urun.Fiyati);
            }

            Console.WriteLine(".....Metotlar...");

            SepetMeneger sepetMeneger = new SepetMeneger();
            sepetMeneger.Ekle(urun1);

        }
    }
}
