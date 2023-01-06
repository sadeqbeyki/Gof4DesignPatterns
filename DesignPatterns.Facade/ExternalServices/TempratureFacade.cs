using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.ExternalServices;

public class TempratureFacade
{
    public int GeTemp(string postalCode)
    {
        var zoneFinder = new ZoneFinder();
        var zone = zoneFinder.GetZone(postalCode);
        var tempratureService = new TempratureService();
        var tempFahrenheit = tempratureService.GetTemp(zone);
        var tempConvertor = new TempratureConvertor();
        var tempCentigrade = tempConvertor.GetCentigrade(tempFahrenheit);
        return tempCentigrade;
    }

}
