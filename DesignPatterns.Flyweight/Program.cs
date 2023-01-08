//Step 5
using DesignPatterns.Flyweight;

var a1 = AlphabetFactory.GetAlpha("A");
var a2 = AlphabetFactory.GetAlpha("A");
var b1 = AlphabetFactory.GetAlpha("B");
a1.Print(1, 2, "red");
a2.Print(2, 2, "blue");
b1.Print(3, 2, "green");

Console.ReadLine();
