namespace DesignPatterns.Builder;
//builder step 4 ترتیب مراحل ساخت پیتزا
public class Pizzabuilder
{
    private readonly PizzaIngredients _pizzaIngredients;

    public Pizzabuilder(PizzaIngredients pizzaIngredients)
    {
        _pizzaIngredients = pizzaIngredients;
        pizzaIngredients.SetBread();
        pizzaIngredients.SetMeat();
        pizzaIngredients.SetCheese();
        pizzaIngredients.SetVegetables();
    }
    public Pizza GetPizza()
    {
        return _pizzaIngredients._pizza;
    }
}
