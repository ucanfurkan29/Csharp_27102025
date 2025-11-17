using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_const_readonly_ctor
{
    internal class ReadOnlyTest
    {
        public readonly int YalnizcaOkunanDeger = 5;
        public ReadOnlyTest()
        {
            
        }
        public ReadOnlyTest(int sayi)
        {
            YalnizcaOkunanDeger = sayi;
        }
    }
}
