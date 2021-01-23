using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //nameing convention
        //xxxxxxxxxxxxxxxxxxxxxxxxxxx
        public void Ekle()
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi!");
        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi" + urunAdi);
        }
    }
}
