namespace FactoryDesignPattern
{
    public abstract class Car
    {
        public abstract void Assemble();
    }

    public class BMW : Car
    {
        public override void Assemble()
        {
            Console.WriteLine("Assembling BMW car");
        }
    }

    public class Mercedese : Car
    {
        public override void Assemble()
        {
            Console.WriteLine("Assembling Mercedese car");
        }
    }

    public class Tata : Car
    {
        public override void Assemble()
        {
            Console.WriteLine("Assembling Tata car");
        }
    }
}