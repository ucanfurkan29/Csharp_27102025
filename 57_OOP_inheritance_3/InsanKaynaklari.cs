using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_OOP_inheritance_3
{
    internal class InsanKaynaklari : Personel
    {
        public int PersonelSayisi { get; set; }

        //CRUD OPERATION -> Create, Read, Update, Delete

        public new void Kayit() //new anahtar kelimesi ile Personel sınıfındaki Kayit metodunu gizliyoruz
        {
            base.Kayit(); //base anahtar kelimesi ile Personel sınıfındaki Kayit metodunu çağırıyoruz
            Console.WriteLine("IseBaslamaTarihi" + IseBaslamaTarihi);
            Console.WriteLine("Personel Sayisi");
            this.PersonelSayisi = int.Parse(Console.ReadLine()); //PersonelSayisi bilgisini alıyoruz
        }

        public static void Listele(List<InsanKaynaklari> liste) //static metot Nedir?
                                                                //static metotlar sınıfa ait olup, nesne oluşturmadan çağrılabilirler
        {
            foreach (InsanKaynaklari insan in liste)
            {
                Console.WriteLine($"{insan.Id} {insan.Ad} {insan.Soyad} {insan.IseBaslamaTarihi} {insan.PersonelSayisi}");
            }
        }

        public static void Sil(List<InsanKaynaklari> liste)
        {
            Listele(liste);
            Console.WriteLine("Silinecek personelin Id'sini giriniz:");
            int id = int.Parse(Console.ReadLine());
            //linq sorgusu
            InsanKaynaklari insanToRemove = liste.FirstOrDefault(i => i.Id == id);
            //listenin elemanlarına bak, benim i deki değerim aslında personeldeki id ve kullanıcının girdiği id değeri benim listemde varsa onu bana getir
            if (insanToRemove == null)
            {
                Console.WriteLine("Girdiğiniz Personel Bulunamadı");
            }
            else
            {
                bool sonuc = liste.Remove(insanToRemove);
                if (sonuc)
                {
                    Console.WriteLine("Personel Başarıyla Silindi");
                }
                else
                {
                    Console.WriteLine("Personel Silinemedi");
                }
            }
        }

        public static void Guncelle(List<InsanKaynaklari> list)
        {
            Listele(list);
            Console.WriteLine("Güncellenecek Personel: ");
            int id = int.Parse(Console.ReadLine());
            InsanKaynaklari insanToUpdate = list.FirstOrDefault(i => i.Id == id);

            if (insanToUpdate == null)
            {
                Console.WriteLine("Personel Bulunamadi");
            }
            else
            {
                insanToUpdate.Kayit(); //güncelleme işlemi için kayıt metodu çağrılıyor
            }
        }
    }
}
