namespace _52_OOP_encapsulation_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
              Bir araba sınıfı oluşturacağız bu sınıfta hız değerimiz kapsüllenmiş bir yapıda olacak ve 
              arabanın hızı max 250km/s i geçmemeli bu yapıda minimum hız negatif bir değer olmamalı
              bu koşullarla hem property i kapsülleyeceğiz hem method ile kapsülleme yapacağız.
              Hızlan ve yavaşlama durumları kapsülleme tipinde olacak.
            */
            Araba araba = new Araba();
            araba.Hiz = 100;
            Console.WriteLine("Başlangıç Hızı: " + araba.Hiz);
            araba.Hizlanma(180);
            araba.Yavaslama(50);
            araba.Hizlanma(150);
            araba.Yavaslama(200);
            araba.Yavaslama(60);


        }
    }
}
