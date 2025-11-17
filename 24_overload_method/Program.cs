namespace _24_overload_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //overload method: aynı isimde fakat farklı parametre yapısına sahip methodlar oluşturmaktır.
            // aynı adı barındıran methodlar farklı görevler yapabilirler.

            Matematik.Topla();
            Matematik.Topla(5, 10);
            Matematik.Topla(5, 10, 15);
            Matematik.Topla(5.5, 10.3);
            Matematik.Topla("Sonuç", 20, 30);
        }
    }
}
