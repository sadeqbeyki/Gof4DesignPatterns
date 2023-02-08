namespace DesignPatterns.Adapter.ExampleA;

public class StoreInHard
{
    public void SaveFile(string text)
    {
        File.WriteAllText(@"D:\output.txt", text);
    }
}
