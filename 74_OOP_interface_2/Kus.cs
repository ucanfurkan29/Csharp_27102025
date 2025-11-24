using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74_OOP_interface_2
{
    internal class Kus : Canli, IYuruyenNesne, IUcanNesne, IYuzenNesne
    {
        public override void HareketEt()
        {
            Console.WriteLine("Ben kuşum uçarım.");
        }
        public void Uc()
        {
            Console.WriteLine("Ben kuşum uçarım.");
        }
        public void Yuru()
        {
            Console.WriteLine("Ben kuşum yürürüm.");
        }
        public void Yuz()
        {
            Console.WriteLine("Ben Kuşum yüzerim");
        }
    }
}
