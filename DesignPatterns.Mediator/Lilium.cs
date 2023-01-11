namespace DesignPatterns.Mediator;


//Mediator step 6
public class Lilium : Airplane
{
    public Lilium(ITower tower, string uniqName) : base(tower)
    {
        AcceptanleDistance = 1000;
        Name = $"Lilium{uniqName}";
    }
}

//step 4