using DP.Creational.AbstractFactory.ExampleA.Cars;

namespace DesignPatterns.Factories.AbstractMethod;
//abstract method
public interface IAbstractFactory
{
    ICar Luxury();
    ICar Compact();
    ICar SUV();
}
