namespace _64_OOP_polymorphism_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Soru: E-Ticaret Ürün KDV Hesaplama Sistemi

                Senaryo: Bir e-ticaret sitemiz var. Sitede Elektronik, Gıda ve Tekstil olmak üzere farklı kategorilerde ürünler satılıyor. Devlet her ürün grubu için farklı KDV oranı belirlemiştir.
                        Standart Ürünler: %18 KDV
                        Elektronik Ürünler: %25 KDV (ÖTV eklendiği için yüksek)
                        Gıda Ürünleri: %8 KDV (Temel ihtiyaç olduğu için düşük)

                Sizden Urun adında bir temel sınıf (base class) ve bu sınıftan türeyen alt sınıfları kullanarak dinamik bir fiyat hesaplama sistemi yazmanız isteniyor.

                Teknik İsterler:
                    Base Class (Urun):
                        Ad (string) ve HamFiyat (double) özellikleri olsun.
                        KdvHesapla() adında virtual bir metot olsun. Bu metot standart olarak ham fiyatın %18'ini hesaplayıp geriye döndürsün.

                    Sub Classes (Tureyen Sınıflar):
                        Elektronik: Urunden türesin. KdvHesapla metodunu override etsin ve ham fiyatın %25'ini hesaplasın.
                        Gida: Urunden türesin. KdvHesapla metodunu override etsin ve ham fiyatın %8'ini hesaplasın.

                    Main Metodu:
                        Birer tane Elektronik (Laptop), Gıda (Ekmek) ve Standart Ürün (Kitap vb.) oluşturun.
                        Ekrana ürünün adını, ham fiyatını, KDV tutarını ve KDV dahil toplam fiyatını yazdırın.
             */

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
        }
    }
}
