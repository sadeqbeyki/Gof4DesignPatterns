namespace DesignPatterns.Observer;

//Step 4
public class Departman : IObserver
{
    public int DepId { get; set; }
    public void Update()
    {
        Console.WriteLine($"Departman  {DepId} Is sad");

    }
}

