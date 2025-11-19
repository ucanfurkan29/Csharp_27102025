using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62_OOP_polymorphism_2
{
    internal class Insan : Canli
    {
        public override void HareketEt()
        {
            base.HareketEt();
            Console.WriteLine("Ben insanım yürürüm");
        }
    }
}
