using System.Collections;

namespace _40_collections_sortedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sorted List(Sıralı Liste)
            //Sözlük tabanlı bir koleksiyon yapısıdır. İçerisinde key-value çifleri saklanır.
            //SortedList eleman olarak verilen keyler unique(benzersiz) değerler olmak zorundadır.
            /*Özellikler
                | Özellik           | Açıklama                                            |
                | ----------------- | --------------------------------------------------- |
                | Veri yapısı       | Anahtar – Değer (key–value)                         |
                | Sıralama          | ✅ Key’e göre otomatik                              |
                | Erişim            | Hem **key** hem **index** ile erişilebilir          |
                | Tekrarlanan key   | ❌ Olmaz (benzersiz olmalı)                          |
                | Tekrarlanan value | ✅ Olabilir                                          |
                | Sıralama türü     | Key’lerin doğal sıralaması (1,2,3... veya A,B,C...) |
                | Namespaces        | `System.Collections` içinde bulunur                 |
             */

            //SortedList siraliListe = new SortedList();
            //siraliListe.Add(06,"Ankara");
            //siraliListe.Add(34,"İstanbul");
            //siraliListe.Add(35,"İzmir");
            //siraliListe.Add(05,"Amasya");
            //siraliListe.Add(01,"Adana");
            //siraliListe.Add(29,"Gümüşhane");
            ////siraliListe.Add("28","Giresun"); //.InvalidOperationException hatası döndürür. Farklı tipte key verilemez

            //foreach (DictionaryEntry item in siraliListe)//DictionaryEntry olarak döngüyü yaptığımızda bize key ve value değerlerini ayrı ayrı almaya olanak sağlar.
            //{
            //    Console.WriteLine(item.Key + " - " + item.Value);
            //}
            //Console.WriteLine("---------------");
            //Console.WriteLine(siraliListe[34]);//key ile erişim
            //Console.WriteLine(siraliListe.GetByIndex(3)); //index numarası ile erişim
            //Console.WriteLine(siraliListe.GetKey(5)); // index numarası ile key e erişim
            //Console.WriteLine(siraliListe.ContainsValue("Ankara"));
            //Console.WriteLine(siraliListe.ContainsKey(01));
            //Console.WriteLine(siraliListe.ContainsKey(81));
            #endregion

            #region Generic Sorted List(Sıralı Liste)
            //SortedList<int,string> genericSiraliListe = new SortedList<int,string>(); //bu liste key olarak int value olarak string almak zorundadir.
            ////Genericler bir sınıfın, methodun ya da collection yapısının datasal anlamda hangi tipte ya da hangi yapıda değer alabileceğini kontrol altına alır.
            //genericSiraliListe.Add(10,"Veli");
            //genericSiraliListe.Add(20,"Ali");
            //genericSiraliListe.Add(30,"Selim");
            ////genericSiraliListe.Add("30",4444); //hatalı bir kullanım şekli

            //foreach (KeyValuePair<int,string> item in genericSiraliListe)//key value ilişkisine göre döngü yapısında getirme yöntemi
            //{
            //    Console.WriteLine(item.Value);
            //    Console.WriteLine(item.Key);
            //}
            //genericSiraliListe.Remove(10);//key değerine göre silme işlemi yapar
            //foreach (KeyValuePair<int, string> item in genericSiraliListe)//key value ilişkisine göre döngü yapısında getirme yöntemi
            //{
            //    Console.WriteLine($"{item.Value} - {item.Key}");
            //}
            #endregion

            #region Örnek:
            //SortedList sozluk = new SortedList()
            //{
            //    {"Bugün","Today"},
            //    {"Yarın","Tomorrow"},
            //    {"Hava","Weather"},
            //    {"Gökyüzü","Sky"},
            //    {"Bir",1}
            //};

            //Console.WriteLine(sozluk["Bir"]);
            //Console.WriteLine(sozluk["Yarın"]);
            //sozluk["iki"] = 2;
            //sozluk["Araba"] = "Car";
            //sozluk["Bir"] = "One";
            //foreach (var item in sozluk)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            /*
                     sözlük uygulaması istenmektedir.Tr - Eng
                  sözlük = { "siyah":"black",,,,}
                     kullanıcı 4 girene kadar sorulur.
                      1 - Arama
                      2 - Çıkarma
                      3 - Listeleme
                      4 - Çıkış

                 Kullanıcı 1'e basarsa ->
                     - Aranacak olan kelimeyi giriniz:
                     -Bu kelime dizide varsa eng karşılığı yazılır.
                     -Yoksa uygulamanın gelişmesine yardımcı olmak ister misiniz(E-H):
                         -E ise bu kelimenin karşılığı istenir ve sözlüğe eklenir
                         -H ise bişey yapılmaz
                 Kullanıcı 2'ye basarsa ->
                     - Çıkarılmak istenen kelime :
                     -Kelime sözlükte varsa çıkartılır
                     - Yoksa uyarı verilir.
                 Kullanıcı 3'e basarsa ->
                     - Tum key value lar listelenir
                     -KEY->VALUE
                 Kullanıcı 4'e basarsa ->
                     - Döngü sonlanır.
                      */
            SortedList<string, string> sozluk = new SortedList<string, string>();
            sozluk.Add("mavi", "blue");
            sozluk.Add("siyah", "black");
            sozluk.Add("beyaz", "white");
            sozluk.Add("turuncu", "orange");
            sozluk.Add("sari", "yellow");

            while (true)
            {
                Console.WriteLine("1-Arama\n2-Çıkarma\n3-Listeleme\n4-Çıkış");
                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    Console.WriteLine("Aranacak Kelime gir: ");
                    string kelime = Console.ReadLine().ToLower();
                    if (sozluk.ContainsKey(kelime))
                    {
                        Console.WriteLine(sozluk[kelime]);
                    }
                    else
                    {
                        Console.WriteLine("Kelime Sözlükte bulunamadı. eklemek istermisin e/h");
                        string cevap = Console.ReadLine().ToLower();
                        if (cevap == "e")
                        {
                            Console.WriteLine($"{kelime} ingilizce karşılığını gir: ");
                            sozluk[kelime] = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("İyi Günler...");
                        }
                    }
                }
                else if (secim == "2")
                {
                    Console.WriteLine("Çıkarmak istediğiniz kelime: ");
                    string kelime = Console.ReadLine();
                    if (sozluk.ContainsKey(kelime))
                    {
                        sozluk.Remove(kelime);
                    }
                    else
                    {
                        Console.WriteLine("Kelime zaten yok");
                    }
                }
                else if (secim == "3")
                {
                    foreach (KeyValuePair<string,string> item in sozluk)
                    {
                        Console.WriteLine($"{item.Value} -> {item.Key}");
                    }
                }
                else if (secim == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim yaptın");
                }
            }
        }
    }
}
