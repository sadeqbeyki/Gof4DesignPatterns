using DesignPatterns.Facade.ExampleA;
using DesignPatterns.Facade.ExampleB;

#region Example A

//var zoneFinder = new ZoneFinder();
//var zone = zoneFinder.GetZone("31312");
//var tempratureService = new TempratureService();
//var tempFahrenheit = tempratureService.GetTemp(zone);
//var tempConvertor = new TempratureConvertor();
//var tempCentigrade = tempConvertor.GetCentigrade(tempFahrenheit);
//return tempCentigrade;

var tempFacade = new TempratureFacade();

Console.WriteLine($"Temprature is : {tempFacade.GeTemp("3423423")}");


//or
//return tempFacade.GeTemp("34234");

#endregion

#region Example B

// The client code may have some of the subsystem's objects already
// created. In this case, it might be worthwhile to initialize the
// Facade with these objects instead of letting the Facade create
// new instances.

Subsystem1 subsystem1 = new();
Subsystem2 subsystem2 = new();
Facade facade = new(subsystem1, subsystem2);
Client.ClientCode(facade);

#endregion
