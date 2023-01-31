namespace DesignPatterns.Strategy.ExampleA;
public class Order
{
    public Order(int price, CalculatePrice calculatePrice)
    {
        Price = price;
        this.calculatePrice = calculatePrice;
    }

    public int Price { get; set; }
    public CalculatePrice calculatePrice { get; set; }
    public int GetFinal()
    {
        return calculatePrice.Calculate(Price);
    }
}


//public class Order2
//{
//    public Order2(int price, Customer customer)
//    {
//        Price = price;
//        Customer = customer;
//    }

//    public int Price { get; set; }
//    public Customer calculatePrice { get; set; }
//    public int GetFinal()
//    {
//        switch (Customer.Type)
//        {
//            case CustomerType.Gold:
//                return Price - 10;
//            case CustomerType.Silver:
//                return Price - 20;
//            case CustomerType.Bronze:
//                return Price - 30;
//            default:
//                return Price;
//        }
//    }
//}