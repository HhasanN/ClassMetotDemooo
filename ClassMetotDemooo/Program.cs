using System;

namespace ClassMetotDemooo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musterı musterı = new Musterı();
            musterı.Id = 001;
            musterı.fırstName = "Mehmet";
            musterı.lastName = "Şahin";
            musterı.musteriAdresi = "Türkiye/Kocaeli";

            Musterı musterı1 = new Musterı();
            musterı1.Id = 002;
            musterı1.fırstName = "Şinasi";
            musterı1.lastName = "Kaftan";
            musterı1.musteriAdresi = "Türkiye/Ankra";

            Musterı musterı2 = new Musterı();
            musterı2.Id = 003;
            musterı2.fırstName = "Kazım";
            musterı2.lastName = "Eskici";
            musterı2.musteriAdresi = "Türkiye/Antalya";

            Musterı[] musteriler = new Musterı[] { musterı, musterı1, musterı2 };

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("-------------- Sisteme Eklenen Müşterileriniz -----------------");
            foreach (Musterı musteri in musteriler)
            {
                musteriManager.Ekle(musteri);
            }

            Console.WriteLine("------------ Sisteme Kayıtlı Olan Müşterilerinizin Bilgileri ---------------");
            foreach (Musterı musteri in musteriler)
            {
                musteriManager.Liste(musteri);
            }

            Console.WriteLine("------------ Sistemden sildiğiniz Müşterilerinizin Bilgileri ---------");
            foreach (Musterı musteri in musteriler)
            {
                musteriManager.Silme(musteri);
            }
        }
    }
}
