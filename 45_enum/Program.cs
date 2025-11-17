namespace _45_enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enumlar sabitler olarak adlandırılırlar. bu veri tipi bize hem sayısal olarak hem de metinsel olarak değer döndürürler. sabit veri yapılarında genelde enum tipi tercih edilir. varsayılan olarak değer atanmazsa 0dan başlar ve sonrakiler birer artarak devam ederler. değerler benzersiz olmalıdır. 
            //enum yapısı genelde bir veriyi veri tabanında sayısal olarak saklayıp daha sonra metinsel olarak erişmek için kullanılabilir.

            //Otomobil otomobil = new Otomobil();
            //otomobil.Marka = Markalar.Mercedes;
            //otomobil.Vites = Vitesler.Otomatik;
            //otomobil.Renk = Renkler.Kırmızı;
            //otomobil.Model = "CLA200";
            //otomobil.KapiSayisi = 4;
            //otomobil.UretimYili = 2024;
            //otomobil.ParkSensoru = true;
            //otomobil.Ceker4 = false;
            //otomobil.MotorHacmi = 1600;

            //otomobil.OzellikYaz();

            #region Enum Yapıları Yazdırma
            Console.WriteLine(Markalar.Bmw);
            Markalar s2 = Markalar.Bmw;
            Console.WriteLine((int)s2);
            Console.WriteLine(s2);
            string[] markalar = Enum.GetNames(typeof(Markalar));
            foreach (var item in markalar)
            {
                Console.WriteLine(item);
            }
            int[] deger = (int[])Enum.GetValues(typeof(Markalar));
            foreach (var item in deger)
            {
                Console.WriteLine(item);
            }

            bool sonuc = Enum.IsDefined(typeof(Markalar), 6);
            bool sonuc2 = Enum.IsDefined(typeof(Markalar), "Bmw");
            Console.WriteLine(sonuc);
            Console.WriteLine(sonuc2);
            #endregion

        }
        enum Markalar { Honda = 1,Mercedes,Bmw,Ford,Renault }
        enum Vitesler { Manuel, Otomatik,YarıOtomatik}
        enum Renkler { Kırmızı, Beyaz,Siyah,Turuncu,Yeşil}
        class Otomobil
        {
            public Markalar Marka;
            public Vitesler Vites;
            public Renkler Renk;
            public int MotorHacmi;
            public int UretimYili;
            public int KapiSayisi;
            public string Model;
            public bool Ceker4;
            public bool ParkSensoru;

            public void OzellikYaz()
            {
                Console.WriteLine($"{Marka} - {Vites} - {Renk} - {MotorHacmi} - { Model} - {Ceker4} - {ParkSensoru}");
            }
        }
    }
}
