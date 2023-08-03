using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_phone
{
    internal  class phone
    {
        public string marka { get; set; }
        public string model { get; set; }
        public int    fiyat { get; set; }
        public string renk { get; set; }
        public int üretimyılı { get; set; }
        public int hafıza { get; set; }

       
        public void özellikmetni()
        {
            Console.WriteLine("marka:"+marka+" model:"+model+" fiyat: "+fiyat+" renk:"+renk+" üretimyılı:"+üretimyılı+" hafıza:"+hafıza);
            Console.ReadLine();
        }
    }
    
}
