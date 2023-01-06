namespace DesignPatterns.Factories.SimpleMethod
{
    public class CarSimpleFactory
    {
        public ICar GetCar(string carName)
        {
            ICar car = null;
            switch (carName)
            {
                case "BMW":
                    car = new BMW();
                    break;
                case "Ford":
                    car = new Ford();
                    break;
            }
            return car;
        }
    }
}
