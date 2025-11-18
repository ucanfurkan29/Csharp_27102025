namespace _58_OOP_inheritance_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Araba diye bir sınıfımız olacak bu yapıda ortak özellikler barınacak 
             * Suv diye bir sınıfımız olacak burada çeker tipi olacak
             * Sport diye bir sınıfımız olacak burada beygir gücü olacak
             * bu yapılar araba sınıfının özelliklerini kullanacaklar ve içindeki arabaları liste halinde gösterecekler
             */
            List<Sport> sports = new List<Sport>()
            {
                new Sport() { Id = 1,Marka = "BMW", Model = "M3", Beygir = 480,Yakit = "Benzin",  Vites = "Manuel"},
                new Sport() { Id = 2,Marka = "Audi", Model = "RS5", Beygir = 450,Yakit = "Benzin",  Vites = "Otomatik"},
                new Sport() { Id = 3,Marka = "Mercedes", Model = "AMG C63", Beygir = 510,Yakit = "Benzin",  Vites = "Otomatik"},
                new Sport() { Id = 4,Marka = "Porsche", Model = "911 Carrera", Beygir = 385,Yakit = "Benzin",  Vites = "Otomatik"},
            };
            List<Suv> suvs = new List<Suv>() 
            { 
                new Suv() { Id = 1,Marka = "Toyota", Model = "RAV4", Ceker = "Önden Çekiş", Yakit = "Hibrit", Vites = "Otomatik"},
                new Suv() { Id = 2,Marka = "Honda", Model = "CR-V", Ceker = "Dört Tekerlekten Çekiş", Yakit = "Benzin", Vites = "Otomatik"},
                new Suv() { Id = 3,Marka = "Ford", Model = "Escape", Ceker = "Dört Tekerlekten Çekiş", Yakit = "Benzin", Vites = "Otomatik"},
                new Suv() { Id = 4,Marka = "Chevrolet", Model = "Equinox", Ceker = "Önden Çekiş", Yakit = "Dizel", Vites = "Otomatik"},
            };

            Suv suv = new Suv();
            suv.Id = 5;
            suv.Marka = "Nissan";
            suv.Model = "Rogue";
            suv.Ceker = "Dört Tekerlekten Çekiş";
            suv.Yakit = "Benzin";
            suv.Vites = "Otomatik";
            suvs.Add(suv);


            Sport sport = new Sport();
            sport.Id = 5;
            sport.Marka = "Chevrolet";
            sport.Model = "Camaro";
            sport.Beygir = 455;
            sport.Yakit = "Benzin";
            sport.Vites = "Manuel";
            sports.Add(sport);

            foreach (Suv item in suvs)
            {
                Console.WriteLine($"{item.Id} {item.Marka} {item.Model} {item.Ceker} {item.Yakit} {item.Vites} ");
            }

            Console.WriteLine("--------------------------------------------------");
            foreach (Sport item in sports)
            {
                Console.WriteLine($"{item.Id} {item.Marka} {item.Model} {item.Beygir} {item.Yakit} {item.Vites} ");
            }


        }
    }
}
