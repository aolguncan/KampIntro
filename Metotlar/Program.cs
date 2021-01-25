using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
<<<<<<< HEAD
            double fiyat = 15;
            string aciklama = "Amasya elması";
=======
            double fiyati = 15;
            string aciklama="Amasya Elması";
>>>>>>> ccfeb2c6cfbbff99f7f5d62b7abd7b5210c9fc35

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
<<<<<<< HEAD
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Kapruz";
=======
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
>>>>>>> ccfeb2c6cfbbff99f7f5d62b7abd7b5210c9fc35
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };
<<<<<<< HEAD

            // type-safe -- tip güvenliği
            foreach (Urun urun in urunler)
=======
            //type-safe -- tip güvenli
            foreach (var urun in urunler)
>>>>>>> ccfeb2c6cfbbff99f7f5d62b7abd7b5210c9fc35
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
<<<<<<< HEAD
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
=======
                Console.WriteLine("-----------------");
            }

          

            Console.WriteLine("-----------------Metotlar------------------------");
            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,8);

        }
    }
}


//Do not repeat yourself - DRY (Kendini Tekrar, aynı kodu tekrar etmek) - Clean Code - Best Practice
>>>>>>> ccfeb2c6cfbbff99f7f5d62b7abd7b5210c9fc35
