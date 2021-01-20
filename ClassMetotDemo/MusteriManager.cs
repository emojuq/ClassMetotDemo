using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri kisiler)
        {
            Console.WriteLine("Sayın  Müşterimiz  " + " " + kisiler.Ad + " " +kisiler.Soyad + " " + kisiler.Id + " Yeni Kaydınız Oluşturulmuştur!");
        }

        public void Listeleme(Musteri kisiler)
        {
            Console.WriteLine("Sayın  Müşterimiz  " + " " + kisiler.Ad + " " + kisiler.Soyad + " " + kisiler.Id + " Kaydınız Listelenmiştir!");
        }

        public void Silme(Musteri kisiler)
        {
            Console.WriteLine("Sayın  Müşterimiz  " + " " + kisiler.Ad + " " + kisiler.Soyad + " " + kisiler.Id + " Kaydınız Silinmiştir!");
        }
    }
}
