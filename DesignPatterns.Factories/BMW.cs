namespace DesignPatterns.Factories;

public class BMW : ICar
{
    public void End()
    {
        Console.WriteLine("BMW End");
    }

    public void Start()
    {
        Console.WriteLine("BMW Start");
    }
}
