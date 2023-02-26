namespace DesignPatterns.Adapter.Adapters;

//Adapter v2 Step 3 
public class InheritanceAdapter : ScreenPrinter, IPrinter
{
    public void Print(string input)
    {
        this.PrintTextToScreen(input);
    }
}
