namespace DesignPatterns.Builder.ExampleA;

//builder step 2
public class Vegetarian : PizzaIngredients
{
    public override void SetBread()
    {
        _pizza.breadType = BreadType.Buget;
    }

    public override void SetCheese()
    {
        _pizza.cheeseType = CheeseType.Cheddar;
    }

    public override void SetMeat()
    {
        _pizza.meatType = MeatType.Bacon;
    }

    public override void SetVegetables()
    {
        _pizza.vegetables = new List<string>
        {
            "onion"
        };
    }
}
