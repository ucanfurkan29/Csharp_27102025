namespace _12_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region goto case örneği
            //string islemYap = "Satış Yap";

            //switch (islemYap)
            //{
            //    case "Stok Eksilt":
            //        Console.WriteLine("Stok Eksiltme İşlemi Yapıldı");
            //        break;
            //    case "Ürün Ekle":
            //        Console.WriteLine("Ürün ekleme işlemi yapıldı");
            //        break;
            //    case "Satış Yap":
            //        Console.WriteLine("Satış İşlemi başarılı");
            //        goto case "Stok Eksilt"; // goto case ile farklı bir case e yönlendirme yapabiliriz.
            //    default:
            //        Console.WriteLine("Hatalı İşlem");
            //        break;
            //}
            #endregion

            // 1-kullanıcıdan önce 2 farklı sayı alın.
            // 2-kullanıcıdan (+,-,*,/) işlemlerden birini seçmesini isteyin
            // 3-switch case yapısı ile hesaplama yapıp ekrana sonucu yazdıran programı yazın.

            Console.WriteLine("1.Sayıyı girin: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.Sayıyı girin: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İşlem Seç: +, -, *, /");
            string islem = Console.ReadLine();

            switch (islem)
            {
                case "+": Console.WriteLine(sayi1 + sayi2); break;
                case "-": Console.WriteLine(sayi1 - sayi2); break;
                case "*": Console.WriteLine(sayi1 * sayi2); break;
                case "/":
                    if (sayi2 != 0)
                    {
                        Console.WriteLine(sayi1 / sayi2);
                    }
                    else
                    {
                        Console.WriteLine("0'a bölme işlemi yapılamaz");
                    }
                    break;
            }



        }
    }
}
