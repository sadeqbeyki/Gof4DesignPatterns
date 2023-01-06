namespace DesignPatterns.Builder;
//builder step 1
public abstract class PizzaIngredients
{
    public readonly Pizza _pizza = new Pizza();
    public abstract void SetBread();
    public abstract void SetMeat();
    public abstract void SetCheese();
    public abstract void SetVegetables();
}
