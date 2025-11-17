using System.Collections;

namespace _39_collections_stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //stack: LIFO (Last in First out) Son giren ilk çıkar.
            //Stack stack = new Stack();
            //stack.Push("Furkan");
            //stack.Push(2);
            //stack.Push('A');
            //stack.Push(true);
            //stack.Push(DateTime.Now);

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("--------------");

            //object sonEleman = stack.Pop(); //İlk elemanı siler
            //Console.WriteLine(sonEleman);
            //Console.WriteLine("------------------");
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------------");
            //Console.WriteLine(stack.Peek()); //ilk elemanı döndürür.

            //Örnek: Web sitesi - Önceki Sayfa - Sonraki Sayfa
            Stack geriStack = new Stack();   // Geri yığını
            Stack ileriStack = new Stack();  // İleri yığını
            string aktifSayfa = "Ana Sayfa"; // Başlangıç sayfa

            string secim = "";

            do
            {
                Console.WriteLine($"\n Şu anki sayfa: {aktifSayfa}");
                Console.WriteLine("1 - Yeni sayfaya git");
                Console.WriteLine("2 - Geri git");
                Console.WriteLine("3 - İleri git");
                Console.WriteLine("4 - Çıkış");
                Console.Write("Seçiminiz: ");
                secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.Write("Gitmek istediğiniz sayfa: ");
                        string yeniSayfa = Console.ReadLine();

                        geriStack.Push(aktifSayfa); // Mevcut sayfayı geri yığına at
                        aktifSayfa = yeniSayfa;     // Yeni sayfaya geç
                        ileriStack.Clear();         // Yeni sayfa gidilince ileri yığını temizlenir
                        break;

                    case "2":
                        if (geriStack.Count > 0)
                        {
                            ileriStack.Push(aktifSayfa);   // Mevcut sayfayı ileri yığınına at
                            aktifSayfa = (string)geriStack.Pop(); // Geri yığından sayfa al
                        }
                        else
                        {
                            Console.WriteLine("Geriye gidilecek sayfa yok!");
                        }
                        break;

                    case "3":
                        if (ileriStack.Count > 0)
                        {
                            geriStack.Push(aktifSayfa);   // Mevcut sayfayı geri yığına at
                            aktifSayfa = (string)ileriStack.Pop(); // İleri yığından sayfa al
                        }
                        else
                        {
                            Console.WriteLine("İleriye gidilecek sayfa yok!");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Program sonlandırıldı.");
                        break;

                    default:
                        Console.WriteLine("Hatalı seçim yaptınız!");
                        break;
                }

            } while (secim != "4");
        }
    }
}
