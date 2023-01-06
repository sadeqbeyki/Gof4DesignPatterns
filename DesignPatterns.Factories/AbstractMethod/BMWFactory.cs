namespace DesignPatterns.Factories.AbstractMethod;

public class BMWFactory : IAbstractFactory
{
    public ICar Compact()
    {
        return new BMWE87();
    }

    public ICar Luxury()
    {
        return new BMWMCoupeE82("blue");
    }

    public ICar SUV()
    {
        return new BMW();
    }
}
