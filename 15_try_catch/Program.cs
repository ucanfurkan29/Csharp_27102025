namespace _15_try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Try-Catch Tanımı
             Hata yakalama işlemi için kullanılır.
            Programın çalışması sırasında oluşabilecek hataları yakalayıp programın kapanmadan hatayı bize göstermeye yarar.
             try
            {
                Çalışmasını istediğimiz kodları tanımlarız

            }
            catch (Exception)
            {
                Try tarafında yazılan kodlarda bir hata meydana gelirse catch bloğu bu hatayı yakalar ve bize gösterir.
                Catch bloğu try da hata olduğu durumda çalışır.
            }
             */

            #region Try-catch-1
            //try
            //{
            //    Console.WriteLine("Bir sayı girin: ");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Sayı: " + sayi);
            //}
            //catch (Exception hata)
            //{
            //    Console.WriteLine("Hata: " + hata.Message);
            //}

            //Console.WriteLine("Try-Catch tarafında program çalışmaya devam eder.");
            #endregion

            #region Try-Catch-2
            //try
            //{
            //    Console.WriteLine("1.Sayıyı girin");
            //    int s1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("2.Sayıyı Girin:");
            //    int s2 = Convert.ToInt32(Console.ReadLine());

            //    double sonuc = s1 / s2;
            //    Console.WriteLine(sonuc);
            //}
            //catch (DivideByZeroException e) 
            //{
            //    Console.WriteLine("Hata: Bir sayı sıfıra bölünemez: " + e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Diğer Hata durumları: " + e.Message);
            //}
            #endregion

            #region Try-Catch-Finally
            try
            {
                int s3 = 10;
                int sonuc2 = s3/2;
                Console.WriteLine(sonuc2);
            }
            catch(Exception)
            {
                Console.WriteLine("Hata");
            }
            finally //finally bloğu hata olsa da olmasa da çalışır.
            {
                Console.WriteLine("Her Durumda Çalışır.");
            }
            #endregion

        }
    }
}
