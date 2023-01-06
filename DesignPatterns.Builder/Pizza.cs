namespace DesignPatterns.Builder;
//builder step 0
public class Pizza
{
    public BreadType breadType;
    public MeatType meatType;
    public CheeseType cheeseType;
    public List<string> vegetables;

    public Pizza()
    {

    }

    public void GetPizza()
    {
        Console.WriteLine("Pizza with:");
        Console.WriteLine(breadType);
        Console.WriteLine(meatType);
        Console.WriteLine(cheeseType);
        Console.WriteLine(string.Join(',', vegetables));
    }
}

//public class Pizza
//{
//    private readonly BreadType breadType;
//    private readonly MeatType meatType;
//    private readonly CheeseType cheeseType;
//    private readonly List<string> vegetables;

//    public Pizza(BreadType breadType, MeatType meatType, CheeseType cheeseType, List<string> vegetables)
//    {
//        this.breadType = breadType;
//        this.meatType = meatType;
//        this.cheeseType = cheeseType;
//        this.vegetables = vegetables;
//    }

//    public void GetPizza()
//    {
//        Console.WriteLine("Pizza with:");
//        Console.WriteLine(breadType);
//        Console.WriteLine(meatType);
//        Console.WriteLine(cheeseType);
//        Console.WriteLine(string.Join(',', vegetables));
//    }
//}
