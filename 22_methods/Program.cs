namespace _22_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Methodlar: yazılımcılar tarafından geliştirilen ve belirli bir görevi yerine getiren kod bloklarıdır.
            //methoda bir isim verilir ve o isim altında işi yapan kod bloğu yazılır. o işi çalıştırmak istediğimizde method ismi çağrılır.
            //methodlar kodun tekrar kullanılabilirliğini sağlar.

            methodlar iç içe tanımlanamazlar.
            methodlar çağırılmadığı sürece çalışmazlar.
            Methodlar 2ye ayrılır:
            değer döndüren methodlar(parametreli/parametresiz)
            değer döndürmeyen methodlar(parametreli/parametresiz)
            methodlar büyük harfle başlar.
            çağırılırken mutlaka (); eklenir.

            */
            Yaz(); //method çağırma
            //Yaz2(); //hata verir çünkü parametre bekliyor
            Yaz2("Ahmet"); //"Ahmet" parametresi ile method çağırma
            Yaz2("Mehmet");
            Console.WriteLine("İsim Girin");
            string ad = Console.ReadLine();
            Yaz2(ad); //kullanıcıdan alınan ad parametresi ile method çağırma

        }
        static void Yaz() //parametresiz ve değer döndürmeyen method. Sadece İş yapar.
        {
            Console.WriteLine("İş yapan parametresiz method");
        }
        static void Yaz2(string isim) //void ifadesi methodun değer döndürmeyen olduğunu belirtir.
        {
            Console.WriteLine($"Merhaba {isim}");
        }
    }
}
