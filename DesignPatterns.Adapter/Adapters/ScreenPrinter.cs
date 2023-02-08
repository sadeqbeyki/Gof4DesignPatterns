namespace DesignPatterns.Adapter.Adapters;

//step 4
public class ScreenPrinter
{
    public bool PrintTextToScreen(string input)
    {
        Console.WriteLine(input);
        return true;
    }
}
