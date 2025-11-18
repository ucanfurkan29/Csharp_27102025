namespace _57_OOP_inheritance_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<InsanKaynaklari> ikListe = new List<InsanKaynaklari>() 
            {
                new InsanKaynaklari() { Id = 1,Ad = "Ayse", Soyad = "Yilmaz",Tc ="1234", PersonelSayisi = 10 },
                new InsanKaynaklari() { Id = 2,Ad = "Mehmet", Soyad = "Kara",Tc ="5678", PersonelSayisi = 15 },
                new InsanKaynaklari() { Id = 3,Ad = "Fatma", Soyad = "Demir",Tc ="9101", PersonelSayisi = 20 },
                new InsanKaynaklari() { Id = 4,Ad = "Ahmet", Soyad = "Sari",Tc ="1121", PersonelSayisi = 25 },
                new InsanKaynaklari() { Id = 5,Ad = "Elif", Soyad = "Celik",Tc ="3141", PersonelSayisi = 30 },
                new InsanKaynaklari() { Id = 6,Ad = "Can", Soyad = "Yildiz",Tc ="5161", PersonelSayisi = 35 }
            };

            while (true)
            {
                Console.WriteLine("Lütfen Birim Seçin \n1-İk \n2-Bilgi işlem\n3-Muhasebe\n4-Çıkış");
                string secim = Console.ReadLine();
                if (secim == "1")
                {
                    Console.WriteLine("Yapmak istediğin işlemi seç \n1-ekle\n2-güncelle\n3-sil\n4-Listele");
                    string islem = Console.ReadLine();
                    if (islem == "1")
                    {
                        InsanKaynaklari yeniIk = new InsanKaynaklari();
                        yeniIk.Kayit();
                        ikListe.Add(yeniIk);
                    }
                    else if (islem == "2")
                    {
                        InsanKaynaklari.Guncelle(ikListe);
                    }
                    else if (islem == "3")
                    {
                        InsanKaynaklari.Sil(ikListe);
                    }
                    else if (islem == "4")
                    {
                        InsanKaynaklari.Listele(ikListe);
                    }
                    else
                    {
                        Console.WriteLine("Hatalı işlem");
                    }
                }
            }



        }
    }
}
