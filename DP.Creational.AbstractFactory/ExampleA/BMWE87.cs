using DP.Creational.AbstractFactory.ExampleA.Cars;

namespace DesignPatterns.Factories.AbstractMethod;

//abstract method
public class BMWE87 : ICar
{
    public void End()
    {
        Console.WriteLine("BMWE87 End");
    }

    public void Start()
    {
        Console.WriteLine("BMWE87 Start");
    }
}
