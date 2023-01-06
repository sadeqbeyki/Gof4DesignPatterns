
using DesignPatterns.Builder;
//builder step 5
Pizzabuilder pizzabuilder = new Pizzabuilder(new Pepperoni());
var pepperoni = pizzabuilder.GetPizza();

Pizzabuilder pizzabuilder1 = new Pizzabuilder(new Vegetarian());
var veg = pizzabuilder1.GetPizza();

Console.WriteLine("Hello, World!");
