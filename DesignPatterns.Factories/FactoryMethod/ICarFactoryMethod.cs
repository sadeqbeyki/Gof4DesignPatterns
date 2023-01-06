namespace DesignPatterns.Factories.FactoryMethod;

public interface ICarFactoryMethod
{
    ICar CreateInstance();
}

public class BmwFactoryMethod : ICarFactoryMethod
{
    public ICar CreateInstance()
    {
        return new BMW();
    }
}

public class FordFactoryMethod : ICarFactoryMethod
{
    public ICar CreateInstance()
    {
        return new Ford();
    }
}

public class BenzFactoryMethod : ICarFactoryMethod
{
    public ICar CreateInstance()
    {
        return new Benz();
    }
}
