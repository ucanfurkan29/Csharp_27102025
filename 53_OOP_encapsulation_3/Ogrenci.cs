using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_OOP_encapsulation_3
{
    internal class Ogrenci
    {
        private string _ad;
        private int _yas;

        public string Ad
        {
            get { return _ad; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (value.StartsWith("A"))
                    {
                        _ad = value;
                        Console.WriteLine(_ad);
                    }
                    else
                    {
                        Console.WriteLine("isim A ile başlamalıdır");
                    }
                }
            }
        }
        public int Yas
        {
            get { return _yas; }
            set 
            {
                if (value > 18)
                {
                    _yas = value;
                    Console.WriteLine(_yas);
                }
                else
                {
                    Console.WriteLine("18 yaşından küçük olamaz");
                }
            }
        }
    }
}
