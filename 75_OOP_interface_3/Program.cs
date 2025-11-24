namespace _75_OOP_interface_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public abstract class Elektronik
    {
        public abstract string Name { get; set; }
        public abstract string Price { get; set; }
    }
    public interface ISarjli
    {
        int SarjSayisi { get; set; }
        int MiliAmper { get; set; }
    }
    public interface IElektrikli
    {
        int volt { get; set; }
        int enerji { get; set; }
    }

    public class Laptop : Elektronik, ISarjli, IElektrikli
    {
        public int SarjSayisi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MiliAmper { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int volt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int enerji { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    public class Buzdolabi : Elektronik, IElektrikli
    {
        public int volt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int enerji { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
