namespace DesignPatterns.Decorator;

public class IceCreamWithChocolate : IceCreamDecorator
{
    public IceCreamWithChocolate(IceCream iceCream) : base(iceCream)
    {
    }

    public override string GetName()
    {
        return $"{base.GetName()} with Chocolate";
    }
    public override int GetPrice()
    {
        return base.GetPrice() * 30;
    }
}