using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_class_object
{
    internal class Ogretmen
    {
        internal int OgretmenNo;
        internal string OgretmenName;
        internal string OgretmenSurName;
        internal int Phone;
        internal void OgretmenTest()
        {
            Console.WriteLine($"Öğretmen Adi: {OgretmenName} Soyadı: {OgretmenSurName} Telefon {Phone}");
        }
    }

}
