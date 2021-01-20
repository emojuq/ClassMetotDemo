using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            Musteri musteri3 = new Musteri();

            musteri1.Ad = "Emre";
            musteri1.Soyad = "Aydın";
            musteri1.Id = 58;


            musteri2.Ad = "Ahmet";
            musteri2.Soyad = "Keskin";
            musteri2.Id = 9;


            musteri3.Ad = "Yunus";
            musteri3.Soyad = "Yürür";
            musteri3.Id = 25;

          

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("------------");

            musteriManager.Listeleme(musteri1);
            musteriManager.Listeleme(musteri2);
            musteriManager.Listeleme(musteri3);

            Console.WriteLine("-------------");

            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Silme(musteri3);

            Console.WriteLine("***************");

            Musteri[] musteri = new Musteri[]
            {
                musteri1,musteri2,musteri3
            };


            foreach (var kisi in musteri)
            {
                Console.WriteLine(kisi.Ad);
                Console.WriteLine(kisi.Soyad);
                Console.WriteLine(kisi.Id);
                Console.WriteLine("----------------");
            };

         


        }
    }
}
