namespace _33_methods_recursive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Recursive Metotlar, bir problemi kendisinin daha küçük bir versiyonuna indirerek çözen metotlardır. Yani "bir büyük problemi,aynı tipte ama daha küçük problemlere bölerek çözmek".


            Console.WriteLine(Faktoriyel(5));

            Console.WriteLine(BasamakTopla(123497586));
        }
        /*
            Faktoriyel(5)
            = 5 * Faktoriyel(4)
            = 5 * (4 * Faktoriyel(3))
            = 5 * 4 * (3 * Faktoriyel(2))
            = 5 * 4 * 3 * (2 * Faktoriyel(1))
            = 5 * 4 * 3 * 2 * 1
            = 120
         */
        static int Faktoriyel(int n)
        {
            if (n == 1) //base case - Metodun durma koşuludur. eğer olmazsa metot sonsuza kadar devam eder ve StackOverFlowException hatası verir.
            {
                return 1;
            }
            else
            {
                return n * Faktoriyel(n - 1);
            }
        }
        static int BasamakTopla(int n)
        {
            if (n < 10)
            {
                return n;
            }
            else
            {
                return (n % 10) + BasamakTopla(n/10); 
            }
        }
    }
}
