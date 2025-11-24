using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71_abstract_6
{
    internal class Araba : Tasit
    {
        public string YakitTuru { get; set; }
        public string VitesTuru { get; set; }
        public Araba(string marka, string model, double tabanFiyat, string vitesTuru, string yakitTuru) : base(marka, model, tabanFiyat) 
            //base ile kalıtım yapılan sınıfın ctor'ını çağırırız
        {
            YakitTuru = yakitTuru;
            VitesTuru = vitesTuru;
        }
        public override double Fiyat
        {
            get
            {
                if (YakitTuru == "Dizel")
                {
                    TabanFiyat += 5000;
                }
                if (VitesTuru == "Otomatik")
                {
                    TabanFiyat += 10000;
                }
                return TabanFiyat;
            }
        }
    }
}
