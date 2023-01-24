namespace DesignPatterns.Decorator.ExampleA;

public class IceCreamWithSmartis : IceCreamDecorator
{
    public IceCreamWithSmartis(IceCream iceCream) : base(iceCream)
    {
    }

    public override string GetName()
    {
        return $"{base.GetName()} with smartis";
    }
    public override int GetPrice()
    {
        return base.GetPrice() * 20;
    }
}
