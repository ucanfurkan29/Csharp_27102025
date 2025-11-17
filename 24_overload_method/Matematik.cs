using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_overload_method
{
    internal class Matematik
    {
        internal static void Topla()//parametresiz overload edilmiş method
        {
            Console.WriteLine("1.sayıyı gir");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayıyı gir");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Toplam: {sayi1 + sayi2}");
        }

        internal static void Topla(int sayi1, int sayi2)//iki int parametre alan overload edilmiş method
        {
            Console.WriteLine("Toplam: " + (sayi1 + sayi2));
        }
        internal static void Topla(int sayi1, int sayi2, int sayi3)//üç int parametre alan overload edilmiş method
        {
            Console.WriteLine("Toplam: " + (sayi1 + sayi2 + sayi3));
        }
        internal static void Topla(double sayi1, double sayi2)//iki double parametre alan overload edilmiş method
        {
            Console.WriteLine("Toplam: " + (sayi1 + sayi2));
        }
        internal static void Topla(string str, int sayi1, int sayi2)//string ve iki int parametre alan overload edilmiş method
        {
            Console.WriteLine($"{str}: {sayi1 + sayi2} ");
        }
    }
}
