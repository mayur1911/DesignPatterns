namespace FactoryDesignPattern
{
    public class CarFactory
    {
        public Car CarCreator(string cartype)
        {
            switch (cartype)
            {
                case "BMW":
                    return new BMW();

                case "Mercedes":
                    return new Mercedese();

                case "Tata":
                    return new Tata();

                default:
                    throw new ArgumentException($"Invalid car type :{cartype}");
            }
        }
    }
}