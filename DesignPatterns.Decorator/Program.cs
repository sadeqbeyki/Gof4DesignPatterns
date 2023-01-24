
#region Example A
//var large = new Large();
//Console.WriteLine(large.GetPrice());
////return large.GetPrice();

//var medium = new Medium();
//Console.WriteLine(medium.GetPrice());

//var small = new Small();    
//Console.WriteLine(small.GetPrice());


using DesignPatterns.Decorator.ExampleA;
using DesignPatterns.Decorator.ExampleB;

var largeIceCream = new Large();
var chocolateIce = new IceCreamWithChocolate(largeIceCream);
Console.WriteLine(chocolateIce.GetName());
Console.WriteLine(chocolateIce.GetPrice());
Console.WriteLine("____________________");

var medium = new Medium();
var smartisMedium = new IceCreamWithSmartis(medium);
Console.WriteLine(smartisMedium.GetName());
Console.WriteLine(smartisMedium.GetPrice());
Console.WriteLine("____________________");

var small = new Small();
var smartisSmall = new IceCreamWithSmartis(small);
var chocolateSmartisSmall = new IceCreamWithChocolate(smartisSmall);
Console.WriteLine(chocolateSmartisSmall.GetName());
Console.WriteLine(chocolateSmartisSmall.GetPrice());
#endregion


#region Example B
Client client = new();
var simple = new ConcreteComponent();
Console.WriteLine("Client: I get a simple component:");
client.ClientCode(simple);
Console.WriteLine();

// ...as well as decorated ones.
//
// Note how decorators can wrap not only simple components but the
// other decorators as well.
ConcreteDecoratorA decorator1 = new(simple);
ConcreteDecoratorB decorator2 = new(decorator1);
Console.WriteLine("Client: Now I've got a decorated component:");
client.ClientCode(decorator2);
#endregion