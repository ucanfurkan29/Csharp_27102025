namespace _13_switch_case_if_else_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             kullanıcıdan alınan cinsiyet bilgisine göre
          ==> ERKEK ise
             yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek, yaş 60'ın altında 
            ise çalıştığı gün sayısına göre eğer 6000 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek,    
            6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
             ==> KADIN ise
              yaşı 58 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, 
            yaş 58'ın altında ise çalıştığı gün sayısına göre eğer 5600 ve üstü ise 
            maaşının 11 katı kadar ikramiye alarak emekli edilecek, 5600 
            altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
             ==> cinsiyet bilgisi switch-case ile sorgulanacak
              */

            Console.Write("Cinsiyeti Girin(erkek/kadın): ");
            string cinsiyet = Console.ReadLine().Trim().ToLower(); //klavyeden "ErkEK" toLower şu değere çevirir => "erkek"
            //.trim() stringin başındaki ve sonundaki boşluk karakterlerini temizler.
            Console.Write("Yaşınızı Girin: ");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Çalıştığın Gün Sayısını Gir: ");
            int calistigiGun = Convert.ToInt32(Console.ReadLine());

            Console.Write("Maaşını Gir: ");
            int maas = Convert.ToInt32(Console.ReadLine());

            bool emekli = false;
            decimal ikramiye = 0m;

            switch (cinsiyet)
            {
                case "erkek":
                    if (yas >= 60)
                    {
                        emekli = true;
                        ikramiye = maas * 10;
                    }
                    else if (calistigiGun >= 6000)
                    {
                        emekli = true;
                        ikramiye = maas * 11;
                    }
                    else
                    {
                        Console.Write("Yaşınız 60dan küçük ve çalıştığınız gün sayısı da 6000den küçük olduğu için ");
                    }
                    break;
                case "kadın":
                    if (yas >= 58)
                    {
                        emekli = true;
                        ikramiye = maas * 10;
                    }
                    else if (calistigiGun >= 5600)
                    {
                        emekli = true;
                        ikramiye = maas * 11;
                    }
                    else
                    {
                        Console.Write("Yaşınız 58den küçük ve çalıştığınız gün sayısı da 5600den küçük olduğu için ");
                    }
                    break;
            }

            if (emekli)
            {
                Console.WriteLine($"emekli Edilecek. İkramiye {ikramiye}");
            }
            else
            {
                Console.WriteLine("emekli Edilmeyecek.");
            }

        }
    }
}
