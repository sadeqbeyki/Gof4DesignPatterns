#region ExampleA
//Step 5
using DP.Structural.Flyweight.ExampleA;

var a1 = AlphabetFactory.GetAlpha("A");
var a2 = AlphabetFactory.GetAlpha("A");
var b1 = AlphabetFactory.GetAlpha("B");
a1.Print(1, 2, "red");
a2.Print(2, 2, "blue");
b1.Print(3, 2, "green");

Console.ReadLine();
#endregion

#region Example B
class Program
{
    static void Main(string[] args)
    {
        // The client code usually creates a bunch of pre-populated
        // flyweights in the initialization stage of the application.
        var factory = new FlyweightFactory(
            new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
            new Car { Company = "Mercedes Benz", Model = "C300", Color = "black" },
            new Car { Company = "Mercedes Benz", Model = "C500", Color = "red" },
            new Car { Company = "BMW", Model = "M5", Color = "red" },
            new Car { Company = "BMW", Model = "X6", Color = "white" }
        );
        factory.listFlyweights();

        addCarToPoliceDatabase(factory, new Car
        {
            Number = "CL234IR",
            Owner = "James Doe",
            Company = "BMW",
            Model = "M5",
            Color = "red"
        });

        addCarToPoliceDatabase(factory, new Car
        {
            Number = "CL234IR",
            Owner = "James Doe",
            Company = "BMW",
            Model = "X1",
            Color = "red"
        });

        factory.listFlyweights();
    }

    public static void addCarToPoliceDatabase(FlyweightFactory factory, Car car)
    {
        Console.WriteLine("\nClient: Adding a car to database.");

        var flyweight = factory.GetFlyweight(new Car
        {
            Color = car.Color,
            Model = car.Model,
            Company = car.Company
        });

        // The client code either stores or calculates extrinsic state and
        // passes it to the flyweight's methods.
        flyweight.Operation(car);
    }
}
#endregion

