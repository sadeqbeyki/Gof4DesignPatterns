//step 1

namespace DP.Creational.AbstractFactory.ExampleB;

// Each distinct product of a product family should have a base interface.
// All variants of the product must implement this interface.
public interface IAbstractProductA
{
    string UsefulFunctionA();
}

// Concrete Products are created by corresponding Concrete Factories.
public class ConcreteProductA1 : IAbstractProductA
{
    public string UsefulFunctionA()
    {
        return "The result of the product A1.";
    }
}

public class ConcreteProductA2 : IAbstractProductA
{
    public string UsefulFunctionA()
    {
        return "The result of the product A2.";
    }
}

