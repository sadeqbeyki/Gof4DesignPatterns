namespace DesignPatterns.Strategy;
//Null Object
public class NullCalculator : CalculatePrice
{
    public override int Calculate(int price)
    {
       return price;
    }
}
