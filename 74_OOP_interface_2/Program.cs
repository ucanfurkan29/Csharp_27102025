namespace _74_OOP_interface_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kus kus = new Kus();
            kus.HareketEt();
            kus.Uc();
            kus.Yuru();
            kus.Yuz();

            Insan insan = new Insan();
            insan.HareketEt();
            insan.Yuru();
            insan.Yuz();

            Balik balik = new Balik();
            balik.HareketEt();
            balik.Yuz();

        }
    }
}
