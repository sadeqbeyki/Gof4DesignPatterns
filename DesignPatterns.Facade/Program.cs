using DesignPatterns.Facade.ExternalServices;

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