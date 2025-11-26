# Manav Stok Yönetim Sistemi

## ?? Proje Açýklamasý

Bu proje, manav iþletmeleri için geliþtirilmiþ kapsamlý bir stok yönetim sistemidir. OOP (Object-Oriented Programming) prensiplerine uygun olarak geliþtirilmiþtir ve .NET 8 Windows Forms teknolojisi kullanýlmýþtýr.

## ?? Özellikler

### 1. Stok Yönetimi
- ? Ürün ekleme, güncelleme ve silme
- ? Detaylý ürün bilgileri (ad, kategori, fiyat, miktar, birim, son kullanma tarihi, tedarikçi)
- ? Kategori bazlý filtreleme (Sebze, Meyve, Kuruyemiþ, Diðer)
- ? Arama fonksiyonu (ürün adý, kategori veya tedarikçiye göre)
- ? Renk kodlu uyarý sistemi
  - ?? Süresi dolmuþ ürünler (Kýrmýzý)
  - ?? Acil satýlmasý gereken ürünler (Turuncu)
  - ?? Dikkat edilmesi gereken ürünler (Sarý)

### 2. Satýþ Ýþlemleri
- ? Hýzlý satýþ yapma
- ? Otomatik stok düþürme
- ? Müþteri bilgisi kaydetme
- ? Anlýk toplam tutar hesaplama
- ? Satýþ geçmiþi görüntüleme

### 3. Raporlar ve Ýstatistikler
- ? **Günlük Rapor**: Satýþ sayýsý ve ciro
- ? **Aylýk Rapor**: Satýþ sayýsý ve ciro
- ? **Toplam Stok Deðeri**: Envanter deðeri hesaplama
- ? **Kritik Stok Uyarýlarý**: Düþük stoklu ürünleri listeler
- ? **Son Kullanma Tarihi Uyarýlarý**: Tarihi yaklaþan ürünleri gösterir
- ? **En Çok Satan Ürünler**: Satýþ performans analizi

## ??? Mimari ve OOP Yapýsý

### Katmanlar

#### 1. Model Katmaný (`Models/`)
- **Urun.cs**: Ürün varlýðý
  - Properties: Id, Ad, Kategori, BirimFiyat, StokMiktari, Birim, SonKullanmaTarihi, Tedarikci
- Methods: `ToplamDeger()`, `DurumKontrol()`

- **SatisKaydi.cs**: Satýþ kaydý varlýðý
  - Properties: Id, UrunId, UrunAd, SatilanMiktar, BirimFiyat, ToplamTutar, SatisTarihi, MusteriAd

#### 2. Business Logic Katmaný (`Business/`)
- **UrunYonetici.cs**: Ürün yönetimi iþ mantýðý
  - `UrunEkle()`: Yeni ürün ekleme
  - `UrunGuncelle()`: Ürün güncelleme
  - `UrunSil()`: Ürün silme
  - `TumUrunleriGetir()`: Tüm ürünleri listeleme
  - `KategoriyeGoreFiltrele()`: Kategori filtreleme
  - `UrunAra()`: Ürün arama
  - `KritikStokUrunler()`: Kritik stok seviyesindeki ürünler
  - `SonKullanmaTarihiYaklasanlar()`: Son kullanma tarihi yaklaþan ürünler
  - `ToplamStokDegeri()`: Toplam envanter deðeri

- **SatisYonetici.cs**: Satýþ yönetimi iþ mantýðý
  - `SatisYap()`: Satýþ iþlemi ve stok düþürme
  - `TumSatislariGetir()`: Satýþ geçmiþi
  - `GunlukRapor()`: Günlük satýþ raporu
  - `AylikRapor()`: Aylýk satýþ raporu
  - `EnCokSatanUrunler()`: En çok satan ürün analizi
  - `ToplamSatisGeliri()`: Toplam gelir hesaplama

#### 3. Presentation Katmaný
- **Form1.cs**: Ana form ve UI mantýðý
  - Stok yönetimi sekmeleri
  - Satýþ iþlemleri arayüzü
  - Raporlama ekranlarý

## ?? Kullanýcý Arayüzü

### Sekmeler
1. **Stok Yönetimi**: Ürün CRUD iþlemleri ve filtreleme
2. **Satýþ Ýþlemleri**: Satýþ yapma ve geçmiþ görüntüleme
3. **Raporlar ve Ýstatistikler**: Detaylý iþ analizleri

## ?? Örnek Veri

Uygulama baþlatýldýðýnda þu ürünler önceden yüklenir:
- Domates (Sebze) - 50 KG
- Salatalýk (Sebze) - 30 KG
- Elma (Meyve) - 40 KG
- Portakal (Meyve) - 60 KG
- Muz (Meyve) - 25 KG
- Patates (Sebze) - 100 KG
- Soðan (Sebze) - 80 KG
- Biber (Sebze) - 20 KG

## ?? Teknolojiler

- **.NET 8.0**: Framework
- **Windows Forms**: UI framework
- **C#**: Programlama dili
- **LINQ**: Veri sorgulama
- **OOP**: Nesne Yönelimli Programlama prensipleri

## ?? Kullaným

1. Projeyi Visual Studio 2022 veya üzeri ile açýn
2. F5 ile uygulamayý baþlatýn
3. Stok Yönetimi sekmesinden ürün ekleyin/düzenleyin
4. Satýþ Ýþlemleri sekmesinden satýþ yapýn
5. Raporlar sekmesinden istatistikleri görüntüleyin

## ?? OOP Prensipleri

### Encapsulation (Kapsülleme)
- Tüm sýnýflarda private field'lar ve public property'ler kullanýlmýþtýr
- Ýþ mantýðý Business katmanýnda kapsüllenmiþtir

### Separation of Concerns (Ýþlev Ayrýmý)
- Model, Business ve Presentation katmanlarý ayrýlmýþtýr
- Her sýnýf tek bir sorumluluða sahiptir

### Abstraction (Soyutlama)
- UI, business logic detaylarýndan soyutlanmýþtýr
- Kullanýcý sadece gerekli metotlarla etkileþime geçer

### Modularity (Modülerlik)
- Her component baðýmsýz olarak geliþtirilebilir ve test edilebilir
- Kod tekrarý minimize edilmiþtir

## ?? Gelecek Geliþtirmeler

- [ ] Veritabaný entegrasyonu (SQL Server / SQLite)
- [ ] PDF rapor çýktýsý
- [ ] Excel'e veri aktarma
- [ ] Barkod okuyucu desteði
- [ ] Çoklu kullanýcý ve yetkilendirme
- [ ] Grafiksel istatistikler (Chart)
- [ ] Tedarikçi yönetimi
- [ ] Sipariþ takip sistemi

## ????? Geliþtirici

Bu proje, modern yazýlým geliþtirme prensipleri ve best practice'ler göz önünde bulundurularak geliþtirilmiþtir.

## ?? Lisans

Bu proje eðitim amaçlý geliþtirilmiþtir.
