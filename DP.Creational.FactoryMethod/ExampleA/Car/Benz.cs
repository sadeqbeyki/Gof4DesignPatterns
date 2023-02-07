namespace DP.Creational.FactoryMethod.ExampleA.Car;

public class Benz : ICar
{
    public void End()
    {
        Console.WriteLine("Benz End");
    }

    public void Start()
    {
        Console.WriteLine("Benz Start");
    }
}
