namespace DesignPatterns.Mediator;

//Mediator step 5
public class Airbus : Airplane
{
    public Airbus(ITower tower, string uniqName) : base(tower)
    {
        AcceptanleDistance = 2000;
        Name = $"Airbus{uniqName}";
    }
}


//step 3