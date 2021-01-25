using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //nameing convention
<<<<<<< HEAD
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi : "+urun.Adi);
        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi : " + urunAdi);
=======
        //xxxxxxxxxxxxxxxxxxxxxxxxxxx
        public void Ekle()
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi!");
        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi" + urunAdi);
>>>>>>> ccfeb2c6cfbbff99f7f5d62b7abd7b5210c9fc35
        }
    }
}
