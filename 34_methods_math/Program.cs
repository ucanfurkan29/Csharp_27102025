namespace _34_methods_math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Pi Sayısı: {Math.PI}");
            Console.WriteLine($"Karekök Alma: {Math.Sqrt(25)}");
            Console.WriteLine($"Kuvvetini alma: {Math.Pow(2, 3)}");
            Console.WriteLine($"Mutlak değer alma: {Math.Abs(-30)}");
            Console.WriteLine($"Maksimum değer: {Math.Max(10, 50)}");
            Console.WriteLine($"Minimum değer: {Math.Min(10, 50)}");
            Console.WriteLine($"Tam Yuvarlama: {Math.Round(3.49)}");
            Console.WriteLine($"Yukarı Yuvarlama: {Math.Ceiling(3.01)}");
            Console.WriteLine($"Aşağı Yuvarlama: {Math.Floor(3.99)}");
        }
    }
}
