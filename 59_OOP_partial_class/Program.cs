namespace _59_OOP_partial_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Parçalı sınıf (Partial Class) Nedir?
                -Parçalı sınıf, bir sınıfın tanımının birden fazla dosyaya bölünmesine olanak tanıyan bir C# özelliğidir.
                -Aynı namespace içinde tanımlanmış ve aynı ada sahip sınıflar, derleme zamanında tek bir sınıf olarak birleştirilir.
                -Bu özellik, büyük sınıfların yönetilmesini kolaylaştırır ve ekip çalışması sırasında kodun daha düzenli olmasını sağlar.
                -partial anahtar kelimesi kullanılarak tanımlanır.
             */

            Personel personel = new Personel();
            personel.Yas = 30;
            personel.Ad = "Ahmet";
            personel.Id = 1;
            //personel.BilgiYazdir(personel.Id);

            personel.Kaydet();

            Personel personel2 = new Personel("Ayşe");
            //Console.WriteLine(personel2.Ad);

        }
    }
}
