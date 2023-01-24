namespace DesignPatterns.Decorator.ExampleA;

public class Medium : IceCream
{
    public override string GetName()
    {
        return "Medium IceCream";
    }
    public override int GetPrice()
    {
        return 150;
    }
}
