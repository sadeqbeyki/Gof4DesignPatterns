using DP.Creational.AbstractFactory.ExampleA.Cars;

namespace DesignPatterns.Factories.AbstractMethod;

//abstract method
public class FordEdge : ICar
{
    public void End()
    {
        Console.WriteLine("FordEdge End");
    }

    public void Start()
    {
        Console.WriteLine("FordEdge Start");
    }
}