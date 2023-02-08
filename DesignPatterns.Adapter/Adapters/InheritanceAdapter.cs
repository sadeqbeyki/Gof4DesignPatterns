namespace DesignPatterns.Adapter.Adapters;

//Adapter v2 Step 3 
public class InheritanceAdapter : ScreenPrinter, IPrint
{
    public void Print(string input)
    {
        this.PrintTextToScreen(input);
    }
}
