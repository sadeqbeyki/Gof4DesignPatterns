using DP.Creational.AbstractFactory.ExampleA.Cars;

namespace DesignPatterns.Factories;

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
