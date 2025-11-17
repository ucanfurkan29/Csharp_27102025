namespace _20_array_metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //******** Clear ********

            //string[] adlar = { "Furkan", "Erkan", "Ahmet", "Ayşe","Kemal","Aslı" };
            ////Array.Clear(adlar); //diziyi tamamen siler
            //Array.Clear(adlar,1,3); //adlar dizisinin 1.indexinden başlayarak 3 eleman siler.
            //foreach (var item in adlar)
            //{
            //    Console.WriteLine(item);
            //}

            // ********** Copy ***********
            //string[] adlar = { "Furkan", "Erkan", "Ahmet", "Ayşe", "Kemal", "Aslı" };
            //string[] adlar2 = new string[10];
            ////Array.Copy(adlar,adlar2,4);
            //Array.Copy(adlar,1,adlar2,2,4);

            //foreach (var item in adlar2)
            //{
            //    Console.WriteLine(item);
            //}

            // ************* IndexOf *************
            //string[] adlar = { "Furkan", "Erkan", "Ahmet", "Ayşe","Furkan", "Kemal", "Aslı" ,"Furkan","Erkan"};
            //int index = Array.IndexOf(adlar,"Furkan"); //Dizi içerisinde aranan değeri ilk bulduğu indexi getirir.
            //Console.WriteLine(index);
            //Console.WriteLine(adlar[index]);

            //int index2 = Array.LastIndexOf(adlar,"Furkan"); //LastIndexOf sonda bulduğu ilk elemanı bana getirir.
            //Console.WriteLine(index2);

            //int index3 = Array.IndexOf(adlar,"Furkan",1);//aramaya hangi indexden başlayacağını söyledik.
            //Console.WriteLine(index3);

            //for (int i = 0; i < adlar.Length; i++)
            //{
            //    int index = Array.IndexOf(adlar,"Furkan", i);
            //    if (index == i)
            //    {
            //        Console.WriteLine(index);
            //    }
            //}


            //While döngüsü ile yazımı
            //int sayac = 0;
            //while (sayac < adlar.Length)
            //{
            //    int index = Array.IndexOf(adlar, "Furkan", sayac);
            //    if (index == sayac)
            //    {
            //        Console.WriteLine(index);
            //    }
            //    sayac++;
            //}


            //*************** Sort & Reverse *******************
            //string[] sehirler = { "Zonguldak","Istanbul","Ankara","Bursa","Canakkale" };
            //Array.Sort(sehirler); //Alfabetik olarak sıralama işlemi yaptı
            //foreach (var item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}

            int[] sayi = { 100, 25, 99, 35, 44, 22, 10, 21, 15 };
            Array.Sort(sayi);//diziyi küçükten büyüğe sıralar
            Array.Reverse(sayi);//diziyi tersine çevirir. sort ile beraber kullanılırsa büyükten küçüğe sıralama yapmış olur
            foreach (var item in sayi)
            {
                Console.WriteLine(item);
            }


        }
    }
}
