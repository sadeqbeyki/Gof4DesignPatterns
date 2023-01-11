namespace DesignPatterns.Mediator;

//Mediator step 5 
public abstract class Airplane: IDisposable
{
    private readonly ITower tower;
    protected Airplane(ITower tower)
    {
        this.tower = tower;
        this.tower.Register(this);
    }

    public string Name { get; set; }
    public int AcceptanleDistance { get; set; }
    public void ChangeAltitude() 
    {
        if (tower.AllowChange())
        {
            //
        }
    }
    public void Dispose()
    {
        tower.Remove(this);
    }
}



//step 1
//public abstract class Airplane 
//{
//    public List<Airplane> Airplanes { get; set; }

//    public string Name { get; set; }
//    public void ChangeAltitude()
//    {
//        if (AllowChange())
//        {
//            //
//        }
//    }
//    public abstract bool AllowChange();
//    public int AcceptanleDistance { get; set; }
//    public Airplane()
//    {
//        Airplanes = new List<Airplane>();
//    }
//}
