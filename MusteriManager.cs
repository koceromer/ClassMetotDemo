using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemoo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Kişi eklendi : " + musteri.Ad + musteri.Soyad);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Kişi Silindi : " + musteri.Ad + musteri.Soyad);
        }


        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Kişi Listelendi : " + musteri.Ad + musteri.Soyad);
        }

    }
}
