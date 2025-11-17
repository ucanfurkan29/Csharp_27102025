namespace _44_class_object_static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Örnek 1
            //List<Araba> list = new List<Araba>();
            ////List<Araba2> list2 = new List<Araba2>(); //static class olduğu için hatalı

            //Araba araba = new Araba();
            //Araba arabam = new Araba();
            ////Araba2 araba2 = new Araba2(); //Static class olduğu için nesne tanımlanmaz

            //araba.Kaydet(list);
            //arabam.Kaydet(list);
            //Araba2.Ekle();

            //foreach (var item in list)
            //{
            //    Console.WriteLine($"{item.Marka} - {item.Model} - {item.Motor} - {item.Fiyat}");
            //}

            #endregion

            #region Örnek 2
            //List<Buzdolabi> liste = new List<Buzdolabi>();
            //Buzdolabi buzdolabi = new Buzdolabi();

            //liste.Add(Buzdolabi.Ekle());
            //Console.WriteLine("-----------");
            //Buzdolabi.Ekle(liste);
            //Console.WriteLine("-----------");

            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item.Marka + " " + item.Model + " " + item.Fiyat);
            //}
            //Console.WriteLine("-----------");

            //buzdolabi.Kaydet();
            //Console.WriteLine("-----------");
            //buzdolabi.Kaydet(liste);
            //Console.WriteLine("-----------");

            //foreach (var item in liste) 
            //{
            //    Console.WriteLine(item.Marka + " " + item.Model + " " + item.Fiyat);
            //}
            #endregion

            #region Örnek 3 
            /* User Diye bir sınıfımız olsun bu alanda kullanıcı adı şifre ad soyad gibi değerler olsun 
             * bu değerler sınıf içerisinde method a eklenecek ve bu method çağrıldığında kullanıcıdan bilgileri alınarak bir listeye atılacak
             * Static ve nonStatic yapılarla yapılsın 
             */

            List<User> users = new List<User>();
            User.Kaydet(users); 
            foreach (var item in users)
            {
                Console.WriteLine($"{item.Name} {item.SurName} {item.UserName}");
            }

            User user = new User();
            Console.WriteLine("Ad:");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyad:");
            string soyad = Console.ReadLine();
            Console.WriteLine("Kullanıcı Adı:");
            string kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifre:");
            string sifre = Console.ReadLine();
            user.Kaydet(ad,soyad,kullaniciAdi,sifre);



            User user2 = new User();
            user2.Name = "Furkan";
            user2.SurName = "Uçan";
            user2.UserName = "ucanfurkan";
            user2.Password = "12345";
            users.Add(user2);

            foreach (var item in users)
            {
                Console.WriteLine($"{item.Name} - {item.SurName} - {item.UserName}");
            }
            #endregion

        }
    }
}
