namespace _51_OOP_encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region OOP
            /*
             Object-Oriented Programming (OOP) -- Nesneye Yönelik Programlama
                - OOP, yazılım geliştirme sürecinde nesneleri ve bu nesnelerin etkileşimlerini temel alan bir programlama paradigmasıdır.
                - OOP'nin temel amacı, kodun daha modüler, yeniden kullanılabilir ve bakımı kolay olmasını sağlamaktır.
                - OOP'nin dört temel prensibi vardır: 
                        -Encapsulation (Kapsülleme) 
                        -Inheritance (Kalıtım)
                        -Polymorphism (Çok Biçimlilik)
                        -Abstraction (Soyutlama).
             */
            /*
             Encapsulation (Kapsülleme)
                - Kapsülleme, verilerin ve bu verilere erişen metodların bir arada tutulmasıdır.
                - Bu, nesnenin iç durumunun dışarıdan doğrudan erişilmesini engeller ve sadece belirli metodlar aracılığıyla erişim sağlar.
                - Kapsülleme, veri gizliliğini artırır ve nesnenin iç yapısının dışarıdan değiştirilmesini önler.
                - Property'ler private olarak tanımlanır ve public metodlar (getter ve setter) aracılığıyla erişilir.
                - Aynı property isminde public olarak tanımlaması yapılır. kullanıcıdan bu property'e veri girişi yapması istenir. setter ile girilen veri private olarak tanımlanan field'a atanır.
                - getter ile private olarak tanımlanan field'dan veri okunur ve kullanıcıya gösterilir.
            */
            #endregion
            //----------------------------------------------------------------------------

            //Vatandas vatandas = new Vatandas();
            //vatandas.AdSoyad = "Ahmet Yılmaz";
            //Console.Write("TC: ");
            //vatandas.Tc = long.Parse(Console.ReadLine());

            //Console.WriteLine("Ad Soyad: " + vatandas.AdSoyad + " TC:" + vatandas.Tc);

            //----------------------------------------------------------------------------

            //string ad = "Furkan";
            //Console.WriteLine(ad); //get işlemi
            //ad = "Irmak";//set işlemi
            //Console.WriteLine(ad); //get işlemi

            //----------------------------------------------------------------------------
            Islem islem = new Islem();
            Console.WriteLine("1.sayi");
            islem.sayi1 = double.Parse(Console.ReadLine());
            Console.WriteLine("2.sayi");
            islem.sayi2 = double.Parse(Console.ReadLine());
            //----------------------------------------------------------------------------
        }
    }
    class Vatandas
    {
        internal string AdSoyad;
        private long _tc;
        public long Tc
        {
            get { return _tc; }
            set 
            {
                if (value.ToString().Length == 11)
                {
                    _tc = value;
                }
                else
                {
                    Console.WriteLine("11 Haneli Giriniz.");
                }
            }
        }
    }

    class Islem
    {
        public double sayi1 { get; set; }
        private double _sayi2 { get; set; }
        public double sayi2 
        { 
            get { return _sayi2; } 
            set 
            {
                if (value > 0 && sayi1 > value)
                {
                    _sayi2 = value;
                    Console.WriteLine($"Bölme: {sayi1 / _sayi2}");
                }
                else if (value == 0)
                {
                    Console.WriteLine("Sfırıa bölünmez");
                }
                else
                {
                    Console.WriteLine("İkinci değer birinci değerden büyük olamaz");
                }
            }
        }
    }
}
