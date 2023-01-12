namespace DesignPatterns.Observer;

//step 3
public class Person : IObserver
{
    public string FullName { get; set; }

    public void Update()
    {
        Console.WriteLine($"{FullName} Is Happy");
    }
}

