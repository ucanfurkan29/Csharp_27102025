using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_OOP_inheritance_3
{
    internal class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tc { get; set; }
        public DateTime IseBaslamaTarihi{ get; set; }
        public Personel()
        {
            IseBaslamaTarihi = DateTime.Now;
        }
        public void Kayit()
        {
            Console.WriteLine("Id");
            this.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ad");
            this.Ad = Console.ReadLine();
            Console.WriteLine("Soyad");
            this.Soyad = Console.ReadLine();
            Console.WriteLine("Tc");
            this.Tc = Console.ReadLine();
        }
    }
}
