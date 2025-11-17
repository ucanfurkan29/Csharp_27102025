namespace _46_enum_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev
            //KitapKategori adında  enum oluşturarak içerisine, BilimKurgu=0, DunyaKlasikleri=1, Psikoloji=2 olmak üzere 3 kategori ekleyelim.
            //Kullanıcıdan string olarak kategori girmesini isteyelim, girilen değeri KitapKategori enum'ına çevirerek switch case ile kontrol edip aşağıda belirtilen şekilde mesajı yazdıran programı yazalım.
            //BilimKurgu ise: "Bilim Kurgu kategorisindeki kitaplar A reyonundadır."
            //DunyaKlasikleri ise:  "Dünya Klasikleri kategorisindeki kitaplar B reyonundadır."
            //Psikoloji ise:  "Psikoloji kategorisindeki kitaplar C reyonundadır."
            #endregion

            Console.WriteLine("Lütfen bir kitap kategorisi giriniz (BilimKurgu, DunyaKlasikleri, Psikoloji):");
            string kategoriInput = Console.ReadLine();

            KitapKategori kitapKategori = (KitapKategori)Enum.Parse(typeof(KitapKategori), kategoriInput,true);

            switch (kitapKategori)
            {
                case KitapKategori.BilimKurgu:
                    Console.WriteLine("Bilim Kurgu kategorisindeki kitaplar A reyonundadır.");
                    break;
                case KitapKategori.DunyaKlasikleri:
                    Console.WriteLine("Dünya Klasikleri kategorisindeki kitaplar B reyonundadır.");
                    break;
                case KitapKategori.Psikoloji:
                    Console.WriteLine("Psikoloji kategorisindeki kitaplar C reyonundadır.");
                    break;
                default:
                    Console.WriteLine("Geçersiz kategori girdiniz.");
                    break;
            }
        }
    }
}
