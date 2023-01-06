namespace DesignPatterns.Decorator;

public class Small : IceCream
{
    public override string GetName()
    {
        return "Small IceCream";
    }
    public override int GetPrice()
    {
        return 100;
    }
}
