namespace _68_OOP_abstract_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Database db;

                Console.WriteLine("Hangi veritabanı? (1-Sql, 2-Oracle)");
                string secim = Console.ReadLine();

                if (secim == "1")
                    db = new SqlDatabase();
                else
                    db = new OracleDatabase();

                // Polymorphism + Abstract
                db.Baglan(); // Hangi sınıfsa onun kodu çalışır
                db.Kaydet();
                db.BaglantiyiKes();
            
        }
    }
    abstract class Database
    {
        // Her veritabanında bağlantı açma kodu %100 farklıdır. 
        // Ortak bir kod yazılamaz, o yüzden Abstract.
        public abstract void Baglan();
        public abstract void Kaydet();

        // Ama bağlantıyı kesme mesajı hepsinde aynı olabilir.
        // Abstract sınıflar içine normal metot da yazılabilir!
        public void BaglantiyiKes()
        {
            Console.WriteLine("LOG: Bağlantı güvenli şekilde kapatıldı.");
        }
    }

    class SqlDatabase : Database
    {
        public override void Baglan()
        {
            Console.WriteLine("Sql Server'a 'SqlConnection' ile bağlanıldı.");
        }

        public override void Kaydet()
        {
            Console.WriteLine("Sql Server: 'INSERT INTO...' komutu çalıştırıldı.");
        }
    }

    class OracleDatabase : Database
    {
        public override void Baglan()
        {
            Console.WriteLine("Oracle DB'ye 'OracleConnection' ile bağlanıldı.");
        }

        public override void Kaydet()
        {
            Console.WriteLine("Oracle: PL/SQL komutu çalıştırıldı.");
        }
    }
}
