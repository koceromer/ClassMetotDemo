using System.ComponentModel;

namespace ClassMetotDemoo
{
    internal class Program:Musteri
    {
        static void Main(string[] args)
        {
            //string Ad = "ali";
            //string Soyad = "lala";
            //int Id = 1;

            Musteri musteri1 = new Musteri();
            musteri1.Ad = "ali";
            musteri1.Soyad = " akak";
            musteri1.Id = 1;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Ömer";
            musteri2.Soyad = " lala";
            musteri2.Id = 2;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Eren";
            musteri3.Soyad = " Lİlli";
            musteri3.Id = 2;


            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager1.Add(musteri1);

            MusteriManager musteriManager2 = new MusteriManager();
            musteriManager2.Delete(musteri2);

            MusteriManager musteriManager3 = new MusteriManager();
            musteriManager3.Listele(musteri3);

        }
    }
}