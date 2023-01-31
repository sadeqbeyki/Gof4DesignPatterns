namespace DesignPatterns.Strategy.ExampleA;
//Null Object
public class NullCalculator : CalculatePrice
{
    public override int Calculate(int price)
    {
        return price;
    }
}
