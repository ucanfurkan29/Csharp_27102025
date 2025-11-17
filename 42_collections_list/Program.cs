namespace _42_collections_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List generic typelar verdiğimiz bize birden fazla elemanı barındıran bir yapı. index kavramıyla çalışır. Arraylistten farklı olarak dataprotected yani tip güvenliği vardır.
            //diziden farklı olarak dizi boyutu belirtmeme gerek yoktur.
            //list yapısı içerisinde her type ı barındırabilir. int,string,datetime,class yapıları olabilir
            //FIFO

            //List<string> list = new List<string>();
            //list.Add("Öğrenci 1");
            //list.Add("Öğrenci 2");
            //list.Add("Öğrenci 3");
            //list.Add("Öğrenci 4");
            //list.Add("Öğrenci 5");
            //list.Add("Öğrenci 6");
            //list.Add("Öğrenci 7");
            //list.Add("Öğrenci 8");
            //list.Add("Öğrenci 9");

            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine($"Capacity: {list.Capacity}");
            //Console.WriteLine($"Count: {list.Count}");

            //list.ForEach(x => Console.WriteLine(x)); //Method foreach yapısı

            List<int> yaslar = new List<int>() { 10,20,30};
            yaslar.Add(14);
            yaslar.Add(44);
            yaslar.Add(25);
            yaslar.AddRange(new List<int> { 34,23,65});//birden fazla eleman tek seferde eklemek.

            yaslar.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("-----------------------");

            //listedeki 30dan büyük olanları ekrana yazdıralım.
            //foreach (int yas in yaslar)
            //{
            //    if (yas >= 30)
            //    {
            //        Console.WriteLine(yas);
            //    }
            //}


            //LİNQ sorgularında çok sık kullandığımız LAMBDA metodu
            //yaslar.Where(yas => yas > 30)
            //    .ToList()
            //    .ForEach(yas => Console.WriteLine(yas));

            int bul = yaslar.Find(y => y == 44);
            Console.WriteLine(bul);

            Console.WriteLine("---------");
            double ortalama = yaslar.Average();
            Console.WriteLine(ortalama);
            Console.WriteLine("----------");

            int index = yaslar.FindIndex(y => y == 23);
            Console.WriteLine(index);

            Console.WriteLine("----------");

            int toplam = yaslar.Sum();
            Console.WriteLine(toplam);

        }
    }
}
