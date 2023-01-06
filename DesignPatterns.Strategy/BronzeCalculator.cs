namespace DesignPatterns.Strategy;

public class BronzeCalculator : CalculatePrice
{
    public override int Calculate(int price)
    {
        return price - 30;
    }
}
