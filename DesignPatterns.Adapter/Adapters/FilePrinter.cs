namespace DesignPatterns.Adapter.Adapters;
//step 2
public class FilePrinter : IPrinter
{
    public void Print(string input)
    {
        File.WriteAllText(@"D:\output.txt", input);
    }
}
