namespace _08_if_else_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 3 adet sayı alınız ve bu sayıları A şeklinde görüldüğü gibi büyükten küçüğe sıralayınız 
            //ve ekrana yazdırınız
            //A Şekli: 15>13>5

            //Daha detaylandırılabilir sorunun cevabı...
            //int a, b, c;

            //Console.WriteLine("1.Sayıyı girin");
            //a = Convert.ToInt32(Console.ReadLine()); 

            //Console.WriteLine("2.Sayıyı girin");
            //b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("3.Sayıyı girin");
            //c = Convert.ToInt32(Console.ReadLine());

            //if (a > b && a > c)
            //{
            //    if (b > c)
            //    {
            //        Console.WriteLine($"{a}>{b}>{c}");
            //    }
            //    else if(c>b)
            //    {
            //        Console.WriteLine($"{a}>{c}>{b}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{a}>{c}={b}");
            //    }
            //}
            //else if (b > a && b > c)
            //{
            //    if (a > c)
            //    {
            //        Console.WriteLine($"{b}>{a}>{c}");
            //    }
            //    else if(c > a)
            //    {
            //        Console.WriteLine($"{b}>{c}>{a}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{b}>{c}={a}");
            //    }
            //}
            //else if (c > a && c > b)
            //{
            //    if (a > b)
            //    {
            //        Console.WriteLine($"{c}>{a}>{b}");
            //    }
            //    else if(b > a) 
            //    {
            //        Console.WriteLine($"{c}>{b}>{a}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{c}>{b}={a}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{c}={b}={a}");
            //}


            //2. ödev
            //Kullanıcıdan şu anki hava sıcaklığını isteyip;
            //Hava sıcaklığı; 5 derece altındaysa "Hava soğuk,Kalın giysiler giyin" uyarısı yapsın.
            // 5 ile 15 arasında ise ; "Hava serin ceket giymeyi unutma" uyarısı.
            //15 ile 25 arasında ise ; "Hava ılık. Rahat şeyler giyebilirsin" uyarısı versin.
            //25 üzeri ise; "Hava sıcaK" uyarısı versin. 

            Console.WriteLine("Hava sıcaklığını girin: ");
            int havaSicakligi = Convert.ToInt32(Console.ReadLine());

            if (havaSicakligi < 5)
            {
                Console.WriteLine("Hava soğuk,Kalın giysiler giyin");
            }
            else if ( 5 <= havaSicakligi && havaSicakligi < 15)
            {
                Console.WriteLine("Hava serin ceket giymeyi unutma");
            }
            else if (15 <= havaSicakligi && havaSicakligi < 25)
            {
                Console.WriteLine("Hava ılık. Rahat şeyler giyebilirsin");
            }
            else
            {
                Console.WriteLine("Hava sıcaK");
            }
        }
    }
}
