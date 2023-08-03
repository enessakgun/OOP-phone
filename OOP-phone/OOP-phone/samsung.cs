using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_phone
{
    internal class samsung:phone
    {
        public void samsungmodelleri()
        {
            Console.WriteLine("1-s22\n2-note10\n3-note11\nçıkış içi 4 e basınız.bir üst menü için 5 e basınız.");
        }

        public void s22()
        {
            samsung samsung = new samsung();
            samsung.marka = "samsung";
            samsung.model = "s22";
            samsung.fiyat = 15000;
            samsung.renk = "sarı";
            samsung.üretimyılı = 2023;
            samsung.hafıza = 256;
            samsung.özellikmetni();
        }
        public void note10()
        {
            samsung samsung = new samsung();
            samsung.marka = "samsung";
            samsung.model = "note10";
            samsung.fiyat = 15000;
            samsung.renk = "sarı";
            samsung.üretimyılı = 2023;
            samsung.hafıza = 256;
               samsung.özellikmetni();
        }
        public void note11()
        {
            samsung samsung = new samsung();
            samsung.marka = "samsung";
            samsung.model = "note11";
            samsung.fiyat = 16000;
            samsung.renk = "sarı";
            samsung.üretimyılı = 2023;
            samsung.hafıza = 256;
            samsung.özellikmetni();
        }
    }
}

