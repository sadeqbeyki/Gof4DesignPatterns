
namespace DesignPatterns.Decorator;
public class IceCreamDecorator : IceCream
{
    private readonly IceCream iceCream;

    public IceCreamDecorator(IceCream iceCream)
    {
        this.iceCream = iceCream;
    }

    public override string GetName()
    {
        return iceCream.GetName();
    }

    public override int GetPrice()
    {
        return iceCream.GetPrice();
    }
}