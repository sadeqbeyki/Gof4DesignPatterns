namespace DesignPatterns.Builder.ExampleA;

//builder step 2
public class Pepperoni : PizzaIngredients
{
    public override void SetBread()
    {
        _pizza.breadType = BreadType.Burger;
    }

    public override void SetCheese()
    {
        _pizza.cheeseType = CheeseType.Goat;
    }

    public override void SetMeat()
    {
        _pizza.meatType = MeatType.Pepperoni;
    }

    public override void SetVegetables()
    {
        _pizza.vegetables = new List<string>
        {
            "Letus",
            "onion"
        };
    }
}
