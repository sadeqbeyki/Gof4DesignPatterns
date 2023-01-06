using DesignPatterns.Factories;
using DesignPatterns.Factories.FactoryMethod;
using DesignPatterns.Factories.SimpleMethod;

//abstract method


//factory method
var carFactory = new BmwFactoryMethod();
var car = carFactory.CreateInstance();
car.Start();
car.End();
Console.ReadKey();
Console.WriteLine("Car Its Ready ! ");

//SimpleFactory
var simpleFactory = new CarSimpleFactory();
ICar bmw = simpleFactory.GetCar("BMW");
ICar ford = simpleFactory.GetCar("Ford");
bmw.Start();
ford.Start();
bmw.End();
ford.End();
Console.ReadKey();

Console.WriteLine("Hello, World!");
