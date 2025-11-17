namespace _30_methods_params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //params methods
            //params anahtar kelimesi bir metoda değişken sayıda argümanın aynı tipte geçirilmesine olanak tanır.
            //params parametresi methodun son parametresi olarak tanımlanmalıdır ve yalnızca params anahtar kelimesi ile kullanılabilir
            //params ile belirtilen parametre bir dizi olarak işlenir bu da methodun içinde bir diziye erişilebileceği ve üzerinde işlem yapılabileceği anlamına gelir.
            Islem(5,6);
            Console.WriteLine("---------------------");
            Islem(7,9,3,9,57,23,66);
            Console.WriteLine("---------------------");
            Yaz(20,"Merhaba",'A',20.5,19,true,DateTime.Now);
        }

        static void Islem(int sayi, int sayi2)
        {
            Console.WriteLine(sayi+ sayi2);
        }
        static void Islem(int sayi, params int[] sayi2)
        {
            Console.WriteLine(sayi);
            foreach (int i in sayi2)
            {
                Console.WriteLine(i);
            }
        }
        static void Yaz(int sayi, params object[] objects)
        {
            Console.WriteLine(sayi);
            foreach (object o in objects)
            {
                Console.WriteLine(o);
            }
        }
    }
}
