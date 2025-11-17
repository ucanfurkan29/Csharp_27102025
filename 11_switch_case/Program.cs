namespace _11_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Switch-Case (Koşul Yapısı)
            switch(koşul)
            {
             case:"Değer1": Yapılacak İş;Break;   
             case:"Değer2": Yapılacak İş;Break;   
             case:"Değer3": Yapılacak İş;Break;   
             case:"Değer4": Yapılacak İş;Break;   
             default:koşulların sağlanmadığı durumda yapılacak iş;break;
            } 
            -switch kısmına değer kısmında kontrol edilecek olan değişken yazılır
            -case kısmında karşılaştırılacak olan ifadeler yazılır.
            -break kısmı eşleşme kısmı çalıştıktan ve eşleştikten sonra çalışacak kodlar bittikten sonra yapıyı sonlandırmak için kullanılır.
            -default ise herhangi bir koşul eşleşmediği durumda çalışacak olan kod bloğudur.(else yapısına benzer.)
             */
            //Console.WriteLine("Aradığınız şehrin plakasını bulun: ");
            //string sehir = Console.ReadLine();

            //switch (sehir)
            //{
            //    case "istanbul": 
            //        Console.WriteLine($"{sehir} plakası 34"); 
            //        break;
            //    case "ankara": 
            //        Console.WriteLine($"{sehir} plakası 06"); 
            //        break;
            //    case "izmir": 
            //        Console.WriteLine($"{sehir} plakası 35");
            //        break;
            //    case "bursa": Console.WriteLine($"{sehir} plakası 16"); break;
            //    case "burdur": Console.WriteLine($"{sehir} plakası 15"); break;
            //    case "düzce": Console.WriteLine($"{sehir} plakası 81"); break;
            //    default: Console.WriteLine("Aradığınız şehir bilgisine ulaşılamadı");break;
            //}

            /*
             Kullanıcıdan bir gün numarası (1–7 arası) alın.
                Buna göre hangi güne denk geldiğini yazdırın.
                Eğer 1 girerse “Pazartesi”, 2 girerse “Salı” …
                7 girerse “Pazar” yazsın.
                Geçersiz sayı girilirse “Hatalı giriş” uyarısı versin.
             */

            Console.WriteLine("Gün numarasını girin: ");
            int gunNumarasi = Convert.ToInt32(Console.ReadLine());

            switch (gunNumarasi)
            {
                case 1: 
                    Console.WriteLine("Pazartesi"); 
                    break;
                case 2:
                    Console.WriteLine("salı");
                    break;
                case 3: 
                    Console.WriteLine("Çarşamba"); 
                    break;
                case 4: 
                    Console.WriteLine("Perşembe"); 
                    break;
                case 5: 
                    Console.WriteLine("Cuma"); 
                    break;
                case 6: 
                    Console.WriteLine("Cumartesi"); 
                    break;
                case 7: 
                    Console.WriteLine("Pazar"); 
                    break;
                default: 
                    Console.WriteLine("Hatalı Giriş"); 
                    break;
            }
        }
    }
}
