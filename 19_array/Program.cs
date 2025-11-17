namespace _19_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* -Diziler: string ifadeler aslında birer dizilerdir. "Furkan" => içerisinde birden fazla değer barındırır.
             * -Diziler içerisinde birden fazla veri barındıran koleksiyon yapılarıdır. diziler tanımlanırken eleman sayıları belirtilmesi  gerekir. değer uzunluğunu belirtmediğimiz durumlar var ama o durumlarda da direkt değerler tanımlanır.
             * -Dizi elemanları çağırılırken veya değer güncellemesi yapılırken index numaralarıyla çağırılırlar.
             * Dizi tanımlama yapısı:
             * int[] dizi_ismi = new int[uzunluk]
             */

            //Boş bir dizi tanımlama
            //string[] isimler = new string[5];
            //isimler[0] = "Furkan";
            //isimler[1] = "Irmak";
            //isimler[2] = "Sevval";
            //isimler[3] = "Yiğit";
            //isimler[4] = "Kaan";
            ////isimler[5] = "Hata verir"; //.IndexOutOfRangeException hatası verir. dizinin boyutunu aşamayız.
            //Console.WriteLine(isimler.Length);
            //Array.Resize(ref isimler, 15);
            //Console.WriteLine(isimler.Length);

            //Console.WriteLine(isimler);//bu şekilde çağırdığımız zaman dizinin değerlerini göstermez. dizinin tipini gösterir.
            //Console.WriteLine(isimler[0]); //[0] index numarası belirtir ve o indexdeki elemanı getirir.
            //Console.WriteLine(isimler.Length);

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}

            //string[] adlar = {"Kaan", "Yiğit","Sevval","Irmak","Özgür","Furkan" }; //dolu bir dizi tanımlaması
            //Console.WriteLine(adlar[2]);

            //int tipinde bir dizi oluşturun. 6 tane eleman ekleyin. for döngüsüyle diziyi ekrana yazdırın.
            //int[] sayilar = { 7, 24, 37, 89, 43, 55, 4, 5, 6, 76, 7, 8, 7, 6 };
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            //while döngüsüyle diziyi ekrana yazdırın.
            //int index = 0;
            //while (index < sayilar.Length)
            //{
            //    Console.WriteLine(sayilar[index]);
            //    index++;
            //}

            //FOREACH döngüsü koleksiyon yapıları içinde dolaşmak için kullanılır.
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            /*SORU: Kullanıcıya kaç personeli olduğunu soralım verilen cevapdan sonra her personelin adını sorup diziye ekleyelim dizi tamamlandıktan sonra personel isimlerini ekrana yazdıralım*/
            //Console.WriteLine("Personel Sayını Gir: ");
            //int personelSayisi = Convert.ToInt32(Console.ReadLine());
            //string[] personeller = new string[personelSayisi];

            //for (int i = 0; i < personeller.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}. Personelin adı:");
            //    string personelIsim = Console.ReadLine();
            //    personeller[i] = personelIsim;
            //}
            //Console.WriteLine("Personeller: ");
            //foreach (string personel in personeller)
            //{
            //    Console.WriteLine(personel);
            //}

            // kullanıcıdan 10 sayı isteyelim ve 3 ün katları olan sayıları bir diziye atalım ve ekrana yazdıran döngüyü yazalım .
            //int[] sayilar = new int[10];
            //for (int i = 0; i < sayilar.Length;)
            //{
            //    Console.WriteLine($"Lütfen {i+1}. sayıyı girin: ");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi % 3 == 0)
            //    {
            //        sayilar[i] = sayi;
            //        i++;
            //    }
            //}
            //Console.Clear();
            //Console.WriteLine("3ün katları olan sayılar: ");
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}


            //boyutu 10 tipi int olan bir dizi oluşturun. kullanıcıdan 10 tane diziye tam sayı eklemesini isteyin. diziye elemanlar eklendikten sonra tek ve çift sayıların toplamını hesaplayın. ekrana yazdırn.
            int[] sayilar = new int[10];
            int ciftToplam = 0;
            int tekToplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine($"{i+1}. sayıyı girin: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    ciftToplam += sayi;
                }
                else
                {
                    tekToplam += sayi;
                }
            }
            Console.Clear();
            Console.WriteLine($"tekToplam:{tekToplam} -- ciftToplam: {ciftToplam}");
        }
    }
}
