namespace DesignPatterns.Decorator.ExampleA;
public class IceCreamDecorator : IceCream
{
    private readonly IceCream _iceCream;

    public IceCreamDecorator(IceCream iceCream)
    {
        _iceCream = iceCream;
    }

    public override string GetName()
    {
        return _iceCream.GetName();
    }

    public override int GetPrice()
    {
        return _iceCream.GetPrice();
    }
}