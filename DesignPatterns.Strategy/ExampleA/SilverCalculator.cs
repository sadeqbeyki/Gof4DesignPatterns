namespace DesignPatterns.Strategy.ExampleA;

public class SilverCalculator : CalculatePrice
{
    public override int Calculate(int price)
    {
        return price - 20;
    }
}
