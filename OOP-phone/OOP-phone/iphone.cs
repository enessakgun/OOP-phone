using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_phone
{
    internal class iphone:phone
    {
        public void iphonemodelleri()
        {
            Console.WriteLine("1-iphonex\n2-iphone11\n3-iphone14\nçıkış içi 4 e basınız.bir üst menü için 5 e basınız.");
        }

        public void iphonex() 
        {
            iphone iphone = new iphone();
            iphone.marka = "iphone";
            iphone.model = "x";
            iphone.fiyat = 15000;
            iphone.renk = "sarı";
            iphone.üretimyılı = 2023;
            iphone.hafıza = 256;
            iphone.özellikmetni();
           
        }
        public void iphone11()
        { 
            iphone iphone = new iphone();
            iphone.marka = "iphone";
            iphone.model = "11";
            iphone.fiyat = 15000;
            iphone.renk = "sarı";
            iphone.üretimyılı = 2023;
            iphone.hafıza = 256;
            iphone.özellikmetni();
        }
        public void iphone14()
        {
            iphone iphone = new iphone();
            iphone.marka = "iphone";
            iphone.model = "14";
            iphone.fiyat = 16000;
            iphone.renk = "sarı";
            iphone.üretimyılı = 2023;
            iphone.hafıza = 256;
            iphone.özellikmetni();
        }
    }
}

