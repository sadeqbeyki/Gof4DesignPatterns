namespace DesignPatterns.Strategy.ExampleA;

public class GoldCalculator : CalculatePrice
{
    public override int Calculate(int price)
    {
        return price - 10;
    }
}
