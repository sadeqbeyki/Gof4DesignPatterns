namespace DesignPatterns.Adapter.Adapters;
//step 2
public class FilePrinter : IPrinter
{
    public void Print(string input)
    {
        File.WriteAllText(@"D:\output.txt", input);
    }
}

//step 4
public class ScreenPrinter
{
    public bool PrintTextToScreen(string input)
    {
        Console.WriteLine(input);
        return true;
    }
}

//Adapter Step 1
public class ObjectAdapter : IPrinter
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

//Adapter v2 Step 3 
public class InheritanceAdapter : ScreenPrinter, IPrinter
{
    public void Print(string input)
    {
        this.PrintTextToScreen(input);
    }
}
