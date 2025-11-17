using System.Collections;

namespace _41_collections_hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            - Hashtable: key sırasının önemli olmadığı ve hızlı key erişimi gerektiğinde ideal olarak kullanılan bir yapıdır.
            - Görevi çok sayıda elemanı saklayıp key değerleriyle hızlı şekilde erişim sağlar.
            - Bir key sadece bir defa kullanılabilir, sortedlist aksine aynı tipte keyler olmak zorunda değildir.
             */

            Hashtable ht = new Hashtable();
            ht.Add("34", "İstanbul");
            ht.Add(6,"Ankara");
            ht.Add(10.5,"Double sayi");
            ht.Add(10.3,"Double sayi");
            ht.Add(true,false);
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine(ht["34"]);
            Console.WriteLine(ht[true]);

        }
    }
}
