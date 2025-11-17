using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_const_readonly_ctor
{
    internal class ConstTest
    {
        public const double Pi = 3.14;

        public ConstTest(double sayi)
        {
            //Pi = sayi; // Hata: Const değerler değiştirilemez.
        }
    }
}
