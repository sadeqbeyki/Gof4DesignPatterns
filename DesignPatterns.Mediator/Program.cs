
using DesignPatterns.Mediator;

internal class Program
{
    private static void Main(string[] args)
    {
        //Mediator step 7
        ITower tehran = new MehrabadTower();

        Boeing boeing = new Boeing(tehran, "001");
        Boeing boeing2 = new Boeing(tehran, "002");
        Airbus airbus = new Airbus(tehran, "001");



        //step 5

        //Boeing boeing = new Boeing("001");
        //Boeing boeing2 = new Boeing("002");

        //boeing.Airplanes.Add(boeing2);
        //boeing2.Airplanes.Add(boeing);

        //Airbus airbus = new Airbus("001");
        //boeing.Airplanes.Add(airbus);
        //airbus.Airplanes.Add(boeing);

        //boeing2.Airplanes.Add(airbus);
        //airbus.Airplanes.Add(boeing2);

        //افزودن هر هواپیمای دیگر به همین شیوه ادامه دار و پیچیده خواهد بود
        Console.WriteLine("Hello, World!");
    }
}