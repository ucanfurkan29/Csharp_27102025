using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63_OOP_polymorphism_3
{
    internal class BankaSistemi
    {
        public virtual void ParaGonder(int tutar)
        {
            Console.WriteLine($"{tutar} kadar havale yapıldı");
        }
    }
}
