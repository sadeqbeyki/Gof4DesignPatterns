namespace DesignPatterns.Strategy;

public class GoldCalculator : CalculatePrice
{
    public override int Calculate(int price)
    {
        return price - 10;
    }
}
