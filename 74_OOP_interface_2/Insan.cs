using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74_OOP_interface_2
{
    internal class Insan : Canli, IYuruyenNesne, IYuzenNesne
    {
        public override void HareketEt()
        {
            Console.WriteLine("Ben insanım spor yapabilirim");
        }

        public void Yuru()
        {
            Console.WriteLine("Ben insanım yürürüm");
        }

        public void Yuz()
        {
            Console.WriteLine("Ben insanım yüzerim");
        }
    }
}
