using DP.Creational.AbstractFactory.ExampleA.Cars;

namespace DesignPatterns.Factories.AbstractMethod;

//abstract method
public class FordEscape : ICar
{
    public void End()
    {
        Console.WriteLine("FordEscape End");
    }

    public void Start()
    {
        Console.WriteLine("FordEscape Start");
    }
}
