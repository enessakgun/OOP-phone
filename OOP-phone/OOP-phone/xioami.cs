using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_phone
{
    internal class xioami : phone
    {
        public void xioamimodelleri()
        {
            Console.WriteLine("1-redmi9\n2-redmi10\n3-note10\nçıkış içi 4 e basınız.bir üst menü için 5 e basınız.");
        }
                       
        public void Redmi9()
        {
            xioami xioami = new xioami();
            xioami.marka = "xioami";
            xioami.model = "redmi9";
            xioami.fiyat = 15000;
            xioami.renk = "sarı";
            xioami.üretimyılı = 2023;
            xioami.hafıza = 256;
            xioami.özellikmetni();
        }
        public void Redmi10()
        {
            xioami xioami = new xioami();
            xioami.marka = "xioami";
            xioami.model = "redmi10";
            xioami.fiyat = 15000;
            xioami.renk = "sarı";
            xioami.üretimyılı = 2023;
            xioami.hafıza = 256;
            xioami.özellikmetni();
        }
        public void note10()
        {
            xioami xioami = new xioami();
            xioami.marka = "xioami";
            xioami.model = "note10";
            xioami.fiyat = 16000;
            xioami.renk = "sarı";
            xioami.üretimyılı = 2023;
            xioami.hafıza = 256;
            xioami.özellikmetni();
        }
    }  
}
