using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_OOP_encapsulation_2
{
    internal class Araba
    {
        private double _hiz;
        private const double MaxHiz = 250;

        public double Hiz
        {
            get { return _hiz; }

            set 
            {
                if (value >= 0 && value <= MaxHiz)
                {
                    _hiz = value;
                }
                else
                {
                    Console.WriteLine($"Hız 0 ile {MaxHiz} arasında olmalı");
                }
            }
        }

        public void Hizlanma(double artis)
        {
            _hiz += artis;
            if (_hiz > MaxHiz)
            {
                _hiz = MaxHiz;
                Console.WriteLine($"Maksimum hıza ulaşıldı. {_hiz}");
            }
            else
            {
                Console.WriteLine($"Şu anki hızınız {_hiz} km/s olarak ayarlandı");
            }
        }
        public void Yavaslama(double azalis)
        {
            _hiz -= azalis;
            if (_hiz <= 0)
            {
                _hiz = 0;
                Console.WriteLine("Araç durdu. Hız 0 km/s");
            }
            else
            {
                Console.WriteLine($"Şu anki hızınız {_hiz} km/s olarak ayarlandı");
            }
        }
    }
}
