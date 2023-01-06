namespace DesignPatterns.Factories.AbstractMethod;

public class FordFactory : IAbstractFactory
{
    public ICar Compact()
    {
        return new FordEdge();
    }

    public ICar Luxury()
    {
        return new FordEscape();
    }

    public ICar SUV()
    {
        return new Ford();
    }
}
