namespace DesignPatterns.Adapter.ExampleA;

public class Printer : IPrinter
{
    public void Print(string input)
    {
        Console.WriteLine(input);
    }
}
