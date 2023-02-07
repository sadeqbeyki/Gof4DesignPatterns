namespace DP.Creational.FactoryMethod.ExampleA.Car;

public class BMW : ICar
{
    public void End()
    {
        Console.WriteLine("BMW End");
    }

    public void Start()
    {
        Console.WriteLine("BMW Start");
    }
}
