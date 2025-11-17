using System.Collections;
using System.Threading.Channels;

namespace _37_manav_otomasyon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Manav Otomasyonu Soru
            /*
            HAL - Toptancı
           * Manava ürün almaya geliyor. Manava "Meyve mi Sebze mi?"
           * 5 adet meyve listelenecek
           * Meyve seçildikten sonra "Kaç Kilo?"
           * Meyve satıldıktan sonra "Başka bir arzunuz var mı?" 
           * Evet derse tekrar "Meyve mi Sebze mi?" satırına döndüreceğiz
           * Hayır. "iyi günler" diyerek manav kısmına geçeceğiz
           * 
           * 
            MANAV
           * "Meyve mi Sebze mi?" diye müşteriye soracağız.
           * Halden almış olduğumuz meyve veya sebzeleri listeleyeceğiz.
           * Müşteri ürün seçtikten sonra "Kaç Kilo?" sorusunu sorun
           * Girilen kilo bilgisini manavın halden aldığı kilo ile kıyaslayarak ürün satınız.
           * Elde olan ürün var olan kilosu kadar satılırsa, manavın ürünlerinden silin.
           * Ürün satıldıktan sonra "Başka bir arzunuz var mı?"
           * Evet derse tekrar "Meyve mi Sebze mi?" satırına döndüreceğiz
           * Hayır derse "Afiyet olsun" Müşteri kısmına geçiniz

           MÜŞTERİ
           * Alınan ürünleri ekrana yazdırınız.
            */
            #endregion

            ArrayList halMeyveler = new ArrayList() { "ELMA", "ARMUT", "KARPUZ", "PORTAKAL", "KAVUN" };
            ArrayList halSebzeler = new ArrayList() { "DOMATES", "BİBER", "PATLICAN", "PATATES", "SOĞAN" };
            ArrayList manavMeyveler = new ArrayList();
            ArrayList manavSebzeler = new ArrayList();
            ArrayList manavMeyveKilo = new ArrayList();
            ArrayList manavSebzeKilo = new ArrayList();
            ArrayList musteri = new ArrayList();

            Console.WriteLine("Hale Hoş Geldiniz");
            while (true)
            {
                Console.WriteLine("Meyve Mi? Sebze Mi? (M/S) çıkış için Q tuşu");
                string halSecim = Console.ReadLine().ToUpper();
                if (halSecim == "M")
                {
                    try
                    {
                        Console.WriteLine("1-Elma \n2-Armut \n3-Karpuz \n4-Portakal \n5-Kavun");
                        string meyve = Console.ReadLine().ToUpper();
                        int meyve2;
                        if (int.TryParse(meyve, out meyve2))
                        {
                            if (meyve2 == 1)
                            {
                                UrunAl(manavMeyveler, "ELMA", manavMeyveKilo);
                            }
                            else if (meyve2 == 2)
                            {
                                UrunAl(manavMeyveler, "ARMUT", manavMeyveKilo);
                            }
                            else if (meyve2 == 3)
                            {
                                UrunAl(manavMeyveler, "KARPUZ", manavMeyveKilo);
                            }
                            else if (meyve2 == 4)
                            {
                                UrunAl(manavMeyveler, "PORTAKAL", manavMeyveKilo);
                            }
                            else if (meyve2 == 5)
                            {
                                UrunAl(manavMeyveler, "KAVUN", manavMeyveKilo);
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Seçim");
                                Thread.Sleep(2000);
                            }
                        }
                        else
                        {
                            if (meyve == "ELMA")
                            {
                                UrunAl(manavMeyveler, "ELMA", manavMeyveKilo);
                            }
                            else if (meyve == "ARMUT")
                            {
                                UrunAl(manavMeyveler, "ARMUT", manavMeyveKilo);
                            }
                            else if (meyve == "KARPUZ")
                            {
                                UrunAl(manavMeyveler, "KARPUZ", manavMeyveKilo);
                            }
                            else if (meyve == "PORTAKAL")
                            {
                                UrunAl(manavMeyveler, "PORTAKAL", manavMeyveKilo);
                            }
                            else if (meyve == "KAVUN")
                            {
                                UrunAl(manavMeyveler, "KAVUN", manavMeyveKilo);
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Seçim");
                                Thread.Sleep(2000);
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("Başka Bir arzunuz var mı? (E/H)");
                        string cevap = Console.ReadLine().ToUpper();
                        if (cevap == "E")
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("İyi Günler");
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata: " + ex.Message);
                    }
                }
                else if (halSecim == "S")
                {
                    try
                    {
                        Console.WriteLine("1-Domates \n2-Biber \n3-Patlıcan\n4-Patates\n5-Soğan");
                        string sebze = Console.ReadLine().ToUpper();
                        int sebze2;
                        if (int.TryParse(sebze, out sebze2))
                        {
                            if (sebze2 == 1)
                            {
                                UrunAl(manavSebzeler, "DOMATES", manavSebzeKilo);
                            }
                            else if (sebze2 == 2)
                            {
                                UrunAl(manavSebzeler, "BİBER", manavSebzeKilo);
                            }
                            else if (sebze2 == 3)
                            {
                                UrunAl(manavSebzeler, "PATLICAN", manavSebzeKilo);
                            }
                            else if (sebze2 == 4)
                            {
                                UrunAl(manavSebzeler, "PATATES", manavSebzeKilo);
                            }
                            else if (sebze2 == 5)
                            {
                                UrunAl(manavSebzeler, "SOĞAN", manavSebzeKilo);
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Seçim");
                                Thread.Sleep(2000);
                            }
                        }
                        else
                        {
                            if (sebze == "DOMATES")
                            {
                                UrunAl(manavSebzeler, "DOMATES", manavSebzeKilo);
                            }
                            else if (sebze == "BİBER")
                            {
                                UrunAl(manavSebzeler, "BİBER", manavSebzeKilo);
                            }
                            else if (sebze == "PATLICA")
                            {
                                UrunAl(manavSebzeler, "PATLICAN", manavSebzeKilo);
                            }
                            else if (sebze == "PATATES")
                            {
                                UrunAl(manavSebzeler, "PATATES", manavSebzeKilo);

                            }
                            else if (sebze == "SOĞAN")
                            {
                                UrunAl(manavSebzeler, "SOĞAN", manavSebzeKilo);
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Seçim");
                                Thread.Sleep(2000);
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("Başka Bir arzunuz var mı? (E/H)");
                        string cevap = Console.ReadLine().ToUpper();
                        if (cevap == "E")
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("İyi Günler");
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata: " + ex.Message);
                    }
                }
                else if (halSecim == "Q")
                {
                    Console.WriteLine("Yine Bekleriz");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim");
                }

            }
            while (true)
            {
                Console.WriteLine("Manava Hoş Geldiniz");
                Console.WriteLine("Meyve Mi Sebze Mi? (M/S)");
                string manavSecim = Console.ReadLine().ToUpper();
                if (manavSecim == "M")
                {
                    if (manavMeyveler.Count == 0)
                    {
                        Console.WriteLine("Meyveler Tükenmiştir.");
                        continue;
                    }
                    for (int i = 0; i < manavMeyveler.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}-{manavMeyveler[i]}-{manavMeyveKilo[i]} kilo mevcut");
                    }
                    try
                    {
                        Console.WriteLine("Ürün Seçiniz");
                        string input = Console.ReadLine().ToUpper();
                        string meyve = "";
                        if (int.TryParse(input,out int meyveNo))
                        {
                            if (meyveNo >= 1 && meyveNo <= manavMeyveler.Count)
                            {
                                meyve = manavMeyveler[meyveNo-1].ToString();
                            }
                            else
                            {
                                Console.WriteLine("Hatalı seçim.");
                                continue;
                            }
                        }
                        else
                        {
                            meyve = input;
                            if (!manavMeyveler.Contains(meyve))
                            {
                                Console.WriteLine("Olmayan ürün");
                                continue;
                            }
                        }
                        if (manavMeyveler.Contains(meyve))
                        {
                            Console.WriteLine("Kaç Kilo");
                            double kilo = Convert.ToDouble(Console.ReadLine());
                            int index = manavMeyveler.IndexOf(meyve);
                            double meyveKilo = (double)manavMeyveKilo[index];
                            if (meyveKilo >= kilo)
                            {
                                meyveKilo -= kilo;
                                musteri.Add($"{meyve}-{kilo} kilo");
                                manavMeyveKilo[index] = meyveKilo;
                                if (meyveKilo == 0)
                                {
                                    manavMeyveler.RemoveAt(index);
                                    manavMeyveKilo.RemoveAt(index);
                                }
                                Console.WriteLine($"Satış başarılı {meyve} için Kalan stok {meyveKilo} kilo");
                            }
                            else
                            {
                                Console.WriteLine("İstenilen Kilo mevcut değil."+meyveKilo + "Kilo mevcut");
                                Thread.Sleep(3000);
                            }
                        }
                        else
                        {
                            Console.WriteLine("olmayan ürün");
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Hata:"+ex.Message);
                    }
                    Console.WriteLine("Başka Bir arzunuz var mı? (E/H)");
                    string cevap = Console.ReadLine().ToUpper();
                    if (cevap == "E")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("İyi Günler");
                        break;
                    }

                }
                else if (manavSecim == "S")
                {
                    
                }
                else if (manavSecim == "Q")
                {
                    
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim");
                }
            }
            Console.WriteLine("Aldığınız Ürünler");
            foreach (var item in musteri)
            {
                Console.WriteLine(item);
            }
        }
        static void UrunAl(ArrayList meyveList,string urun,ArrayList kiloList)
        {
            if (meyveList.Contains(urun) == false)
            {
                meyveList.Add(urun);
                Console.WriteLine("Kaç Kilo?");
                double kilo = Convert.ToInt32(Console.ReadLine());
                kiloList.Add(kilo);
            }
            else
            {
                Console.WriteLine("Kaç Kilo?");
                double kilo = Convert.ToInt32(Console.ReadLine());
                int index = meyveList.IndexOf(urun);
                double meyveKilo = (double)kiloList[index];
                meyveKilo += kilo;
                kiloList[index] = meyveKilo;
            }
        }

    }
}
