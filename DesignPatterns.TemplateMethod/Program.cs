using DesignPatterns.TemplateMethod.ExampleA;
using DesignPatterns.TemplateMethod.ExampleB;

#region Example A
PizzaCooker pizzaCooker= new Pepperoni();
PizzaCooker vegetableCooker = new Vegetable();
Console.WriteLine("Hello, World!");
#endregion



#region Example B
Console.WriteLine("Same client code can work with different subclasses:");

Client.ClientCode(new ConcreteClass1());

Console.Write("\n");

Console.WriteLine("Same client code can work with different subclasses:");
Client.ClientCode(new ConcreteClass2());
#endregion