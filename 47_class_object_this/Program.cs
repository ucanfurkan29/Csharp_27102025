namespace _47_class_object_this
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.Kaydet(10, 20);
            dikdortgen.Yazdir();
        }
    }

    public class Dikdortgen
    {
        private int En;
        private int Boy;

        public void Kaydet(int en, int Boy)
        {
            En = en;
            this.Boy = Boy; // this kullanımı ile sınıfın üyesini belirttik
            //this o anda çalışan nesneyi temsil eder, field-parametre ayrımını sağlar
        }
        public void Yazdir()
        {
            Console.WriteLine($"{En} - {Boy}");
        }
    }
}
