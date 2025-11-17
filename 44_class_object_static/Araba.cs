using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _44_class_object_static
{
    internal class Araba
    {
        public int Id;
        public string Marka;
        public string Model;
        public double Motor;
        public double Fiyat;

        public void Kaydet(List<Araba> list)
        {
            Console.WriteLine("Marka:");
            Marka = Console.ReadLine();
            Console.WriteLine("Model:");
            Model = Console.ReadLine();
            Console.WriteLine("Motor:");
            Motor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Fiyat:");
            Fiyat = Convert.ToDouble(Console.ReadLine());

            list.Add(this);//this bu sınıftaki özellikleri listeye ekle dedik.
        }

    }
}
