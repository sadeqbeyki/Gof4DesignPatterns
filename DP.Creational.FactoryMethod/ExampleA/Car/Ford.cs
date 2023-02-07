namespace DP.Creational.FactoryMethod.ExampleA.Car;

public class Ford : ICar
{
    public void End()
    {
        Console.WriteLine("Ford End");
    }

    public void Start()
    {
        Console.WriteLine("Ford Start");
    }
}
