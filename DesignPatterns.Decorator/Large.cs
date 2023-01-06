namespace DesignPatterns.Decorator;

public class Large : IceCream
{
    public override string GetName()
    {
        return "Large IceCream";
    }

    public override int GetPrice()
    {
        return 200;
    }
}
