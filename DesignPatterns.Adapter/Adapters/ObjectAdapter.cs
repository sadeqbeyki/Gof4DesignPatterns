namespace DesignPatterns.Adapter.Adapters;

//Adapter Step 1
public class ObjectAdapter : IPrint
{
    private readonly ScreenPrinter _screenPrinter;

    public ObjectAdapter()
    {
        _screenPrinter = new ScreenPrinter();
    }

    public void Print(string input)
    {
        _screenPrinter.PrintTextToScreen(input);
    }
}
