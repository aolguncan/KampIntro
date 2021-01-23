using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyat = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Kapruz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            // type-safe -- tip güvenliği
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------");
            }

            Console.WriteLine("------Methods-----");
            //instance - örnek
            //encapsulation
            SepetManager urunManager = new SepetManager();
            urunManager.Ekle(urun1);
            urunManager.Ekle(urun2);

            urunManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            urunManager.Ekle2("Elma", "Yeşil Elma", 9, 9);
            urunManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 19, 8);
        }
    }
}