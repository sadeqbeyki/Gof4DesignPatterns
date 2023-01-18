namespace DesignPatterns.Facade.ExampleA;

public class TempratureFacade
{
    public int GeTemp(string postalCode)
    {
        var zoneFinder = new ZoneFinder();
        var zone = zoneFinder.GetZone(postalCode);
        var tempratureService = new TempratureService();
        var tempFahrenheit = tempratureService.GetFahrenheitTemp(zone);
        var tempConvertor = new TempratureConvertor();
        var tempCentigrade = tempConvertor.GetCentigradeTemp(tempFahrenheit);
        return tempCentigrade;
    }
}

