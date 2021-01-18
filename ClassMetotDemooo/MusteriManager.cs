using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemooo
{
    class MusteriManager
    {

        public void Ekle(Musterı musterı)
        {
            Console.WriteLine(musterı.fırstName + " " + musterı.lastName + "  " + "İsimli Müşteriniz Sisteme Eklenmiştir.");
            Console.WriteLine("      ");
        }

        public void Liste(Musterı musterı)
        {
            Console.WriteLine("Müşteri İsmi : " + musterı.fırstName);
            Console.WriteLine("Mşteri Soyadı : " + musterı.lastName);
            Console.WriteLine("Müşteri Adresi : " + musterı.musteriAdresi);
            Console.WriteLine("Müşteri Id : " + musterı.Id);
            Console.WriteLine("     ");
        }

        public void Silme(Musterı musterı)
        {
            Console.WriteLine(musterı.fırstName + " " + musterı.lastName + "  " + "İsimli Müşteriniz Listeden Silinmiştir.");
            Console.WriteLine("      ");
        }
    }
}
