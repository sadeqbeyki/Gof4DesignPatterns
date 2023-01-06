
//var large = new Large();
//Console.WriteLine(large.GetPrice());
////return large.GetPrice();

//var medium = new Medium();
//Console.WriteLine(medium.GetPrice());

//var small = new Small();    
//Console.WriteLine(small.GetPrice());


using DesignPatterns.Decorator;

var largeIceCream = new Large();
var chocolateIce = new IceCreamWithChocolate(largeIceCream);
Console.WriteLine(chocolateIce.GetPrice());
Console.WriteLine("____________________");

var medium = new Medium();
var smartisMedium = new IceCreamWithSmartis(medium);
Console.WriteLine(smartisMedium.GetPrice());
Console.WriteLine("____________________");

var small = new Small();
var smartisSmall = new IceCreamWithSmartis(small);
var chocolateSmartisSmall = new IceCreamWithChocolate(smartisSmall);
Console.WriteLine(chocolateSmartisSmall.GetPrice());