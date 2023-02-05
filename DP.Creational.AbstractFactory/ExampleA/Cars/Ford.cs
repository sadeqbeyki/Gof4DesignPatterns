using DP.Creational.AbstractFactory.ExampleA.Cars;

namespace DesignPatterns.Factories;

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
