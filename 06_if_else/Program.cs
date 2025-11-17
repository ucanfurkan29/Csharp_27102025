namespace _06_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Karar Yapısı (Conditions) İf-else, Switch-Case
            //if-else if-else blokları senkronize olarak çalışırlar. bir yapıda birden fazla else if bloğu bulunabilir. koşullardan herhangi birisi çalışırsa eğer o koşuldan sonraki koşul bloklarına bakılmaksızın sağlanan koşulun bloğundaki kod çalışır. kod bittikten sonra if bloğunun sonundan devam eder program. hiçbir koşul sağlanmaması durumunda else bloğu çalışır.

            Console.WriteLine("Bir Sayı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 0)
            {
                Console.WriteLine("Sayı Sıfırdan Büyüktür.");
            }
            else if (sayi < 0)
            {
                Console.WriteLine("Sayı Sıfırdan Küçüktür.");
            }
            else
            {
                Console.WriteLine("Sayı Sıfıra Eşittir.");
            }


        }
    }
}
