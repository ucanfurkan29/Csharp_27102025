namespace _29_methods_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ödev 
             static void KelimeSayilariniGoster isminde bir method tanımlayın ve parametresi string metin olsun. 
            Bu method string türünde verilen metin içindeki kelimeleri ayrıştırarak hangi kelimenin kaç kez tekrar ettiğini ekranda göstersin.

                char[] ayracKarakterler = { ' ', ',', '.', '!', '?', ';', ':' };
                string[] kelimeler = metin.ToLower().Split(ayracKarakterler, StringSplitOptions.RemoveEmptyEntries);
             */

            string tekerleme = "Pohpohçu pinti profesör pofur pofur pofurdayarak hınçla tunç çanak içinde punç içip pulverizatör prospektüsünü papaz balığı biblosunun berisindeki papatya buketinin bu yanına bıraktıktan sonra palas pandıras Pülümürlü Pötürgelinin getirdigi pörsük pötikare pöstekiyi Paluluların pıtırcık pazarında partenogenes pasaparolasını, pertavsız pervasız pervaz peyzajını ve perenospora pesterkerani pestilini posbıyıklı pisboğaz pedegoga Pınarbaşı’nda beş peşkirle peş peşe peşin peşkeş çekti, sonra da pılısmı pırtısmı topladı: ” Pingpong, pingpong, pingpong Piyango pingpong! Pingpong, pingpong! ” diyerek Posof’un pisipisi otundan yapılma pistovsu piposunu tüttüre tüttüre paytak paytak yürüyüp gitti.";

            string metin2 = "Gürbüz, \"Bugün takımımız çok iyi mücadele verdi. Hocamızı, teknik ekibimizi, tüm oyuncularımızı tebrik ediyoruz. Çok yoğun bir çalışma içerisinde takımımız. 1 haftada 2 maç oynadık. Enerjileri çok yüksek. Çok çalışıyorlar. Bundan sonraki maçlarda en iyisini yapacaklar. Lig uzun maraton. Maç maç bakıyoruz. Takım çok iyi seviyeye gelmek üzere hocamızla birlikte. Taraftarımızın yoğun ilgisi ve yoğun desteği takımımızı yukarı çekti. Takım iyi oynayınca taraftar destekliyor, taraftar destekleyince takım iyi oynuyor. Çok iyi yoldayız. Milli ara var kısa. Milli arayı çok iyi değerlendirip takımımızı daha hazır hale getirmeye çalışacağız. Planlarımızı yaptık\" dedi.";

            KelimeSayilariniGoster(tekerleme);
            KelimeSayilariniGoster(metin2);
        }

        static void KelimeSayilariniGoster(string metin) 
        {
            char[] ayracKarakterler = { ' ', ',', '.', '!', '?', ';', ':', '”' };
            string[] kelimeler = metin.ToLower().Split(ayracKarakterler, StringSplitOptions.RemoveEmptyEntries);
            string[] benzersizKelimeler = new string[kelimeler.Length];
            int[] kelimeSayilari = new int[kelimeler.Length];
            int benzersizIndex = 0;

            foreach (var kelime in kelimeler)
            {
                bool bulundu = false;

                for (int i = 0; i < benzersizIndex; i++)
                {
                    if (benzersizKelimeler[i] == kelime)
                    {
                        kelimeSayilari[i]++;
                        bulundu = true;
                        break;
                    }
                }
                if (!bulundu)
                {
                    benzersizKelimeler[benzersizIndex] = kelime;
                    kelimeSayilari[benzersizIndex] = 1;
                    benzersizIndex++;
                }

            }

            Array.Sort(kelimeSayilari, benzersizKelimeler, 0, benzersizIndex);
            Array.Reverse(kelimeSayilari,0,benzersizIndex);
            Array.Reverse(benzersizKelimeler,0,benzersizIndex);


            for (int i = 0; i < benzersizIndex; i++)
            {
                Console.WriteLine($"{benzersizKelimeler[i]}' Kelimesi {kelimeSayilari[i]} kez geçiyor.");
            }
            Console.WriteLine("----------------------------------------------------------------------");

        }

    }
}
