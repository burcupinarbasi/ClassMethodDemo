using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            Musteri [] musteriler = new Musteri[] { };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri);
            musteriManager.listele(musteri);
            musteriManager.sil();


            Console.WriteLine("tamamlandı.");


        }
    }
}
