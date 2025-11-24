namespace _73_OOP_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region INTERFACE (ARAYÜZ) NEDİR?
            /*
            Bir sınıftan kalıtım almak güçlü bir mekanizmadı. Ancak asıl kalıtımın gücü interface ile kalıtım almasında görülür.
            Bir sınıf kalıtımla sadece bir sınıftan türeyebilirken, bir sınıf birden fazla interface'den kalıtım alabilir.
            Interface'ler sadece imza barındırırlar. İçerisinde gövde ve kod barındırmazlar.
            Interface'ler new'lenemezler(nesnelenemez). Sadece onlardan kalıtım alan sınıflar new'lenebilir.
            Interface'ler bir sözleşme gibidir. Bir sınıf bir interface'den kalıtım aldığında, o interface'ın tüm imzalarını almak zorundadır.
            Interface'ler I harfi ile başlarlar. Örneğin: ICalisan, IOgrenci gibi.

            Interface neden kullanılır ve faydaları nedir?
            1. Çoklu Kalıtım: C#'ta bir sınıf sadece bir sınıftan kalıtım alabilir. Ancak bir sınıf birden fazla interface'den kalıtım alabilir. Bu sayede çoklu kalıtım ihtiyacı karşılanmış olur.
            2. Esneklik ve Gevşek Bağlılık: Interface'ler sayesinde sınıflar arasındaki bağımlılıklar azaltılır. Bu da kodun daha esnek ve sürdürülebilir olmasını sağlar.
            3. Küçük çaplı projelerde interface kullanımı gereksiz görünebilir. Ancak büyük ve karmaşık projelerde interface kullanımı kodun yönetilebilirliğini artırır. küçük projede tek bir geliştirici olduğu için hangi sınıfta ne olduğunu bilmesi kolaydır. Ancak büyük projelerde birden fazla geliştirici çalıştığı için interface kullanımı kodun anlaşılabilirliğini artırır.

            - arayüz tanımlamak için "interface" anahtar kelimesi kullanılır.
            - erişim belirleyicileri (public, private, protected) interface tanımlarında kullanılmaz. Çünkü interface'ler varsayılan olarak public'tir.

            Kısıtlamalar: 
            - Interface'ler alan (field) veya değişken tanımlayamazlar.
            - Interface'ler yapıcı (constructor) tanımlayamazlar.
            - Interface'ler static olamazlar.
            - Interface'ler sealed olamazlar.
             */
            #endregion
        }
    }
}
