using DP.Creational.AbstractFactory.ExampleA.Cars;

namespace DesignPatterns.Factories.AbstractMethod;

//abstract method
public class BMWMCoupeE82 : ICar
{
    public BMWMCoupeE82(string color)
    {
    }

    public void End()
    {
        Console.WriteLine("BMWSeriesSeven End");
    }

    public void Start()
    {
        Console.WriteLine("BMWSeriesSeven Start");
    }
}
