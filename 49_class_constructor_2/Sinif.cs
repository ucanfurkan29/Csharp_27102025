using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_class_constructor_2
{
    internal class Sinif
    {
        public double No { get; set; } //get getirmek ve görüntülemek
                                       //set atamak ve değiştirmek

        public double Kapasite { get; set; }

        public Sinif()
        {
            Console.WriteLine("Parametre almayan ctor çalıştı...");
        }
        public Sinif(int no)
        {
            No = no;
            Console.WriteLine("Bir Parametreli ctor çalıştı");
        }
        public Sinif(int no , int kapasite)
        {
            No = no;
            Kapasite = kapasite;
            Console.WriteLine("İki Parametreli int ctor çalıştı");
        }
        public Sinif(double no, double kapasite)
        {
            No = no;
            Kapasite = kapasite;
            Console.WriteLine("İki parametreli double ctor çalıştı");
        }

    }
}
