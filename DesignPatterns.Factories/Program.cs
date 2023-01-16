using DesignPatterns.Factories;
using DesignPatterns.Factories.SimpleMethod;


//SimpleFactory
var simpleFactory = new CarSimpleFactory();
ICar bmw = simpleFactory.GetCar("BMW");
ICar ford = simpleFactory.GetCar("Ford");
bmw.Start();
ford.Start();
bmw.End();
ford.End();
Console.ReadKey();