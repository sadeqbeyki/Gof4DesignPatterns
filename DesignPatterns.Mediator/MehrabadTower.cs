namespace DesignPatterns.Mediator;

//Mediator step 2
public class MehrabadTower : ITower
{
    public List<Airplane> Airplanes { get; set; } = new List<Airplane>();

    public bool AllowChange()
    {
        var result = false;
        //به ازای همه لیست های هواپیما ها چک کنیم فاصله مجازشان را
        foreach (var item in Airplanes)
        {
            if (item is Boeing)
            {
                var temp = item as Boeing;
                //calc result
            }
            if (item is Airbus)
            {
                var temp = item as Airbus;
                //calc result
            }
            if (item is Lilium)
            {
                var temp = item as Lilium;
                //calc result
            }
        }
        return result;
    }

    public void Register(Airplane airplane)
    {
        Airplanes.Add(airplane);
    }

    public void Remove(Airplane airplane)
    {
        Airplanes.Remove(airplane);
    }
}