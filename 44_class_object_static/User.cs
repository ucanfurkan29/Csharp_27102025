using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_class_object_static
{
    internal class User
    {
        public string Name;
        public string Password;
        public string UserName;
        public string SurName;

        public static void Kaydet(List<User> users)
        {
            User user = new User();
            Console.WriteLine("Ad:");
            user.Name = Console.ReadLine();
            Console.WriteLine("Soyad:");
            user.SurName = Console.ReadLine();
            Console.WriteLine("Kullanıcı Adı:");
            user.UserName = Console.ReadLine();
            Console.WriteLine("Şifre:");
            user.Password = Console.ReadLine();

            users.Add(user);
        }

        public void Kaydet(string ad, string soyad,string kullaniciAdi, string sifre)
        {
            Name = ad;
            SurName = soyad;
            UserName = kullaniciAdi;
            Password = sifre;
            Console.WriteLine($"Kullanici adi:{UserName} Ad: {Name} Soyad: {SurName}");
        }
    }
}
