namespace _65_OOP_polymorphism_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Banka Ödeme Simülasyonu (Parametreli & Mantıksal Polymorphism)
                Senaryo: Bir alışveriş sitemiz var. Müşteri 1000 TL'lik bir ürün alıyor. Ancak ödeme ekranında seçtiği yönteme göre bankaların kestiği komisyon oranları veya ek hizmet bedelleri değişiyor.

                Sizden OdemeYontemi adında bir yapı kurmanız ve aşağıdaki kuralları uygulamanız isteniyor:

                Teknik İsterler:
                    Base Class (OdemeYontemi):
                        OdemeYap(double tutar) isimli virtual bir metodu olsun.
                        Bu metot varsayılan olarak: "Ödeme başarıyla alındı. Tutar: [Tutar]" yazsın ve geriye işlemden sonraki net tutarı (değiştirmeden) döndürsün.
                    Sub Classes (Türeyen Sınıflar):
                        KrediKarti: Banka %5 komisyon almaktadır.
                        OdemeYap metodunu override edin.
                        Girilen tutarın %5 fazlasını hesaplayıp ekrana "Kredi Kartı ile ödeniyor. %5 Banka Komisyonu Eklendi." yazsın.
                        Geriye komisyonlu tutarı döndürsün.

                        KapidaOdeme: Kargo şirketi sabit 20 TL hizmet bedeli almaktadır.
                        OdemeYap metodunu override edin.
                        Girilen tutara 20 TL ekleyip ekrana "Kapıda Ödeme seçildi. +20 TL Hizmet Bedeli yansıtıldı." yazsın.
                        Geriye yeni tutarı döndürsün.

                        Masterpass (Kampanyalı): Bu yöntemde %0 komisyon vardır.
                        Base class'taki metodu olduğu gibi kullansın (Override etmeye gerek yok, veya base'i çağırıp ek mesaj verebilir).
                    Main Metodu:
                    Sepet tutarı 1000 TL olsun.
                    Bu 3 ödeme yöntemini bir listede tutun.
                    Döngü ile her bir yöntemi çalıştırın ve müşterinin cebinden çıkacak Son Tutarı ekrana yazdırın.
             */

            double sepetTutari = 1000;
            List<OdemeYontemi> odemeYontemleri = new List<OdemeYontemi>()
            {
                new KrediKarti(),
                new KapidaOdeme(),
                new MasterPass()
            };
            foreach (var odemeYontemi in odemeYontemleri)
            {
                double sonTutar = odemeYontemi.OdemeYap(sepetTutari);
                Console.WriteLine($"Müşterinin cebinden çıkacak son tutar: {sonTutar}\n");
            }
        }
    }
    class OdemeYontemi
    {
        public virtual double OdemeYap(double tutar)
        {
            Console.WriteLine($"Ödeme başarıyla alındı. Tutar: {tutar}");
            return tutar;
        }
    }
    class KrediKarti : OdemeYontemi
    {
        public override double OdemeYap(double tutar)
        {
            Console.WriteLine("Kredi Kartı ile ödeniyor. %5 Banka Komisyonu Eklendi.");
            return tutar * 1.05;
        }
    }
    class KapidaOdeme : OdemeYontemi
    {
        public override double OdemeYap(double tutar)
        {
            Console.WriteLine("Kapıda Ödeme seçildi. +20 TL Hizmet Bedeli yansıtıldı.");
            return tutar + 20;
        }
    }
    class MasterPass : OdemeYontemi
    {
        // Base class'taki metodu olduğu gibi kullanıyor.
        public override double OdemeYap(double tutar)
        {
            Console.WriteLine("Masterpass ile ödeme yapılıyor. %0 Komisyon uygulanıyor.");
            return base.OdemeYap(tutar);
        }
    }

}

