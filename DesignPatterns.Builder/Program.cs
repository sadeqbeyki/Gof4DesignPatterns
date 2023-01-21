using DesignPatterns.Builder;
using DesignPatterns.Builder.ExampleA;
using DesignPatterns.Builder.ExampleB;

#region Example A
//builder step 5
Pizzabuilder pizzabuilder = new Pizzabuilder(new Pepperoni());
var pepperoni = pizzabuilder.GetPizza();

Pizzabuilder pizzabuilder1 = new Pizzabuilder(new Vegetarian());
var veg = pizzabuilder1.GetPizza();

Console.WriteLine("Hello, World!");
#endregion

#region Example B
// The client code creates a builder object, passes it to the
// director and then initiates the construction process. The end
// result is retrieved from the builder object.
var director = new Director();
var builder = new ConcreteBuilder();
director.Builder = builder;

Console.WriteLine("Standard basic product:");
director.BuildMinimalViableProduct();
Console.WriteLine(builder.GetProduct().ListParts());

Console.WriteLine("Standard full featured product:");
director.BuildFullFeaturedProduct();
Console.WriteLine(builder.GetProduct().ListParts());

// Remember, the Builder pattern can be used without a Director
// class.
Console.WriteLine("Custom product:");
builder.BuildPartA();
builder.BuildPartC();
Console.Write(builder.GetProduct().ListParts());
#endregion

