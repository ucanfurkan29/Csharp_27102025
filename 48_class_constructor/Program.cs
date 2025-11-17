namespace _48_class_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* -----Constructor-----
                -class ile aynı isme sahip olan ve new keyword'u ile çağrılan özel bir metottur.
                -class'ın bir örneği (instance) oluşturulduğunda otomatik olarak çalışır.
                -genellikle nesne oluşturulurken bazı başlangıç değerlerini atamak için kullanılır.
                -default olarak boş bir şekilde her class için görünmez şekilde oluşturulur.
                -eğer biz bir constructor tanımlarsak default constructor ortadan kalkar.
                -bir class içinde birden fazla constructor tanımlanabilir (overloading).
                -herhangi bir dönüş terimi yoktur, void int return yazılmaz.
            */
            Customer customer = new Customer();
            Customer customer2 = new Customer("Ali","Yılmaz","30");
            customer.Yaz();
            customer2.Yaz();
        }
        class Customer
        {
            public string Ad;
            public string Soyad;
            public string Yas;

            public void Yaz()
            {
                Console.WriteLine($"Test {Ad} {Soyad} {Yas}");
            }

            //default constructor
            public Customer()
            {
                Console.WriteLine("Customer sınıfında nesne oluşturuldu. Default ctor çalıştı");
            }
            public Customer(string ad,string soyad,string yas)
            {
                Ad = ad;
                Soyad = soyad;
                Yas = yas;
                Console.WriteLine("Parametreli ctor çalıştı.");
            }
        }
    }
}
