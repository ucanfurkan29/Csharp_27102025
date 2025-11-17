namespace _50_const_readonly_ctor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Const nedir?
            //Const, derleme zamanında sabit olan ve değiştirilemeyen değerler için kullanılır.
            //Const değerler tanımlandığında mutlaka bir değer atanmalıdır ve bu değer daha sonra değiştirilemez.

            //double sayi = 3.14;
            //sayi = 3.15;
            //Console.WriteLine(sayi);

            //const double pi = 3.14;
            ////pi = 3.15; // Hata: Const değerler değiştirilemez.
            //Console.WriteLine(pi);

            ////ConstTest constTest = new ConstTest(3.15); // Hata: Const değerler değiştirilemez.

            //double sayi2 = ConstTest.Pi;
            //Console.WriteLine(sayi2 + 10);
            //Console.WriteLine(ConstTest.Pi);

            //Readonly nedir?
            //Readonly, çalışma zamanında bir kez atanabilen ve daha sonra değiştirilemeyen değerler için kullanılır.
            //Readonly alanlar, constructor içinde atanabilir.
            //Readonly alanlar, tanımlandıklarında bir değer atanabilir veya constructor içinde atanabilir.

            ReadOnlyTest readOnlyTest = new ReadOnlyTest();
            //readOnlyTest.YalnizcaOkunanDeger = 42; // Hata: Readonly alanlar sadece constructor içinde atanabilir.
            Console.WriteLine(readOnlyTest.YalnizcaOkunanDeger);

            ReadOnlyTest readOnlyTest1 = new ReadOnlyTest(100);

            Console.WriteLine(readOnlyTest1.YalnizcaOkunanDeger);



        }
    }
}
