using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _44_class_object_static
{
    internal class Buzdolabi
    {
        public int Id;
        public string Marka;
        public string Model;
        public double Fiyat;

        public static void Ekle(List<Buzdolabi> lists) //static iş yapan bir metot
        {
            Buzdolabi buzdolabi = new Buzdolabi();
            Console.WriteLine("Marka");
            buzdolabi.Marka = Console.ReadLine();
            Console.WriteLine("Model");
            buzdolabi.Model = Console.ReadLine();
            Console.WriteLine("Fiyat");
            buzdolabi.Fiyat = Convert.ToDouble(Console.ReadLine());

            lists.Add(buzdolabi);
        }
        public static Buzdolabi Ekle()//Static değer döndüren overload bir metot
        {
            Buzdolabi buzdolabi=new Buzdolabi();
            Console.WriteLine("Marka");
            buzdolabi.Marka = Console.ReadLine();
            Console.WriteLine("Model");
            buzdolabi.Model = Console.ReadLine();
            Console.WriteLine("Fiyat");
            buzdolabi.Fiyat = Convert.ToDouble(Console.ReadLine());
            return buzdolabi;
        }

        public void Kaydet() //non-static iş yapan bir metot
        {
            Console.WriteLine("Marka");
            Marka = Console.ReadLine();
            Console.WriteLine("Model");
            Model = Console.ReadLine();
            Console.WriteLine("Fiyat");
            Fiyat = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Marka + " " + Model + " " + Fiyat);
        }
        public void Kaydet(List<Buzdolabi> list)
        {
            Console.WriteLine("Marka");
            Marka = Console.ReadLine();
            Console.WriteLine("Model");
            Model = Console.ReadLine();
            Console.WriteLine("Fiyat");
            Fiyat = Convert.ToDouble(Console.ReadLine());

            list.Add(this);
        }


    }
}
