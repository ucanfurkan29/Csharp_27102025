using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74_OOP_interface_2
{
    internal class Balik : Canli, IYuzenNesne
    {
        public override void HareketEt()
        {
            Console.WriteLine("Denizde Hareket ederim.");
        }
        public void Yuz()
        {
            Console.WriteLine("Ben balığım yüzerim.");
        }
    } 
}
