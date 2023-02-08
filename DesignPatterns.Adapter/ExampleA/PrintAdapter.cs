
namespace DesignPatterns.Adapter.ExampleA;

public class PrintAdapter : IPrinter
{
    private readonly StoreInHard _storeInHard;

    public PrintAdapter()
    {
        _storeInHard = new StoreInHard();
    }

    public void Print(string input)
    {
        _storeInHard.SaveFile(input);
    }
}
