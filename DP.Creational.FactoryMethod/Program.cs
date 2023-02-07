using DesignPatterns.Factories.FactoryMethod;
using DP.Creational.FactoryMethod.ExampleB;

#region Example A

var carFactory = new BmwFactoryMethod();
var car = carFactory.CreateInstance();
car.Start();
car.End();
Console.ReadKey();
Console.WriteLine("Car Its Ready ! ");

#endregion


#region Example B

new Client().Main();

#endregion