using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            musteri.Id = 1234;
            musteri.Name = "Burcu";
            musteri.Surname = "Pinarbasi";
            Console.WriteLine("eklendi.");

        }

        public void listele(Musteri musteri)
        {
            Console.WriteLine("musteri ıd="+musteri.Id);
            Console.WriteLine("musteri ad="+musteri.Name);
            Console.WriteLine("musteri soyad="+musteri.Surname);
        }

        public void sil()
        {
            Console.WriteLine("musteri silindi");
        }
    }
}
