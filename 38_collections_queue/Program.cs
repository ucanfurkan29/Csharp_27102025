using System.Collections;

namespace _38_collections_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //queue: çalışma prensibi FIFO (First In First Out) ilk giren ilk çıkar. dinamik data tipi alır.
            /*
            | Özellik                 | **Queue**                                                               | **ArrayList**                                                           |
            | ----------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
            | **Veri erişim mantığı** | **FIFO (First In – First Out)** → ilk giren ilk çıkar                   | **Rastgele erişim** (index ile erişim yapılabilir)                      |
            | **Erişim şekli**        | `Dequeue()` ile baştan eleman çıkarılır, `Enqueue()` ile sona eklenir   | `Add()` ile eklenir, `[index]` ile erişilir veya `Remove()` ile silinir |
            | **Kullanım amacı**      | Sıralı işlemler, bekleme sırası (örnek: yazıcı kuyruğu, müşteri sırası) | Liste mantığıyla veri tutmak, dizinin dinamik hali                      |
            | **Index erişimi**       |  Yok (direkt 2. elemanı alamazsın)                                      | Var (`list[1]` şeklinde erişebilirsin)                                  |
            | **Ekleme/Çıkarma**      | Sadece uçlardan (baştan çıkar, sondan ekle)                             | Listenin herhangi bir yerine ekleme/çıkarma yapılabilir                 |
            | **Performans amacı**    | Akış veya sıra yönetimi için optimize edilmiştir                        | Genel amaçlı veri listesi yönetimi için optimize edilmiştir             |

             */
            //Queue kuyruk = new Queue();
            //kuyruk.Enqueue("Furkan");//Kuyruğa ekleme yapar
            //kuyruk.Enqueue("Kaan");
            //kuyruk.Enqueue("Sevval");
            //kuyruk.Enqueue("Irmak");

            //foreach (var item in kuyruk)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("-------------------");
            //kuyruk.Dequeue(); //kuyruktaki ilk elemanı siler.

            //foreach (var item in kuyruk)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-------------------");

            //object ilkEleman = kuyruk.Peek(); //kuyruktaki ilk elemanı silmeden bize getirir.
            //Console.WriteLine(ilkEleman);

            //Console.WriteLine("-------------------");
            //Console.WriteLine(kuyruk.Contains("Kaan"));//aradığım eleman var mı diye bakar
            //Console.WriteLine(kuyruk.Count);//kaç eleman var onu gösterir
            //kuyruk.Clear();//kuyruğu temizler
            //Console.WriteLine(kuyruk.Count);


            //Örnek:
            Queue musteriKuyrugu = new Queue();
            string secim = "";

            do
            {
                Console.WriteLine("\nBanka Müşteri Sırası");
                Console.WriteLine("1- Müşteri Ekle");
                Console.WriteLine("2- Sıradaki Müşteriyi Al");
                Console.WriteLine("3- Kuyruktaki Müşterileri Göster");
                Console.WriteLine("4- Çıkış");
                Console.Write("Seçiminiz");
                secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.Write("\nMüşteri Adı:");
                        string ad = Console.ReadLine();
                        musteriKuyrugu.Enqueue(ad);
                        Console.WriteLine($"\n{ad} kuyruğa eklendi.");
                        break;
                    case "2":
                        if (musteriKuyrugu.Count > 0)
                        {
                            string siradaki = Convert.ToString(musteriKuyrugu.Dequeue());
                            Console.WriteLine($"\n{siradaki} hizmet aldı ve sıradan çıkartıldı.");
                        }
                        else
                        {
                            Console.WriteLine("\nKuyrukta Müşteri Yok!");
                        }
                        break;
                    case "3":
                        if (musteriKuyrugu.Count > 0)
                        {
                            Console.WriteLine("\nKuyruktaki Müşteriler");
                            foreach (var item in musteriKuyrugu)
                            {
                                Console.WriteLine("-"+item);
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nKuyrukta Hiç Müşteri Yok!");
                        }
                        break;
                    case "4": Console.WriteLine("\nProgram Sonlandırıldı"); break;
                    default: Console.WriteLine("\nHatalı Seçim Yaptınız.");break;
                }

            }
            while (secim != "4");
        }
    }
}
