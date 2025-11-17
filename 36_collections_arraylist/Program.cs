using System.Collections;

namespace _36_collections_arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Collection: Birden fazla veriyi bir arada tutmaya yarayan yapılardır.
            //statik colection -> Array
            //Dinamik colection -> ArrayList,List,Queue,Stack,Dictionary

            //ArrayList: Farklı türlerde verileri tutabilen dinamik boyutlu bir koleksiyondur.
            //Yani Array gibi ama daha esnektir.
            //Özellikler:
            //1-Boyut sınırı yoktur, eleman eklendikçe büyür.
            //2-İçinde her türden veri (int,string,bool,vs.) saklanabilir.
            //3-Ancak bu yüzden tip güvenliği yoktur.
            //4-System.Collection namespaceinde bulunur.
            //5-Kapasitesi 2üzeri n  olara hesaplanır. yani -> 2^2 = 4  -> 5 eleman varsa 4 kapasite yetmez bir büyütür 2^3 =8 e çıkar

            //ArrayList list = new ArrayList { "Merhaba", 10, 22.5, 'A', DateTime.Now, true,false};

            //ArrayList list2 = new ArrayList();
            //list2.Add(10);
            //list2.Add('B');
            //list2.Add("Selam");
            //list2.Add(15.3);
            //list2.Add(false);
            //list2.Add(true);
            //list2.Add(DateTime.Now);
            //list2.Add("Furkan");
            //list2.Add("Uçan");

            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(list2.Capacity);//Listenin boyutunu gösterir
            //Console.WriteLine(list2.Count);//Listenin içindeki eleman sayısı


            ////? if anlamına gelir. : ise else anlamına gelir.
            //string deger = 9 > 15 ? "Büyüktür." : "Küçüktür";
            //Console.WriteLine(deger);

            //Console.WriteLine(list2.Contains("sevval") ? "Var" : "Yok");
            //Console.WriteLine(list2.Contains("Furkan") ? "Var" : "Yok");


            //list2.RemoveAt(2);//belirttiğim index numarasındaki elemanı siler
            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}

            //list2.Remove("Uçan");//Belirttiğim elemanı siler, bulamazsa görmezden gelir hata vermez.
            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}

            //list2.RemoveRange(2,4);//2.indexden başla, 4 eleman sil
            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}

            //list2.Insert(0,"Yiğit");//belirttiğim indexe eleman ekleme
            //list2.Insert(5, "Irmak");
            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}

            //list2.Reverse();
            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}

            ArrayList sayilar = new ArrayList();
            sayilar.Add(1);
            sayilar.Add(20);
            sayilar.Add(3);
            sayilar.Add(47);
            sayilar.Add(55);
            sayilar.Add(623);
            sayilar.Add(20);
            sayilar.Add(72);
            sayilar.Add(85);


            int index = sayilar.IndexOf(20);
            int index2 = sayilar.LastIndexOf(20);

            Console.Write(index + " ");
            Console.WriteLine(sayilar[index]);
            Console.WriteLine(index2);

            Console.WriteLine($"Silme Öncesi count {sayilar.Count}");
            sayilar.Clear();
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(sayilar.Capacity);
            Console.WriteLine($"Silme sonrası count {sayilar.Count}");
            Console.WriteLine("Foreach Döngüsü bitti.");

        }
    }
}