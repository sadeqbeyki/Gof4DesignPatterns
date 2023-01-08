namespace DesignPatterns.Flyweight;

//Step 1
public abstract class Alphabet
{
    protected string character;
    public void Print(int x, int y, string color)
    {
        Console.WriteLine($"x: {x} y: {y} color : {color} {character}");
    }
}
//Step 2
public class AAlphabet : Alphabet
{
    public AAlphabet()
    {
        character = "A";
        Console.WriteLine("Create new instance of A");
    }
}

//Step 3
public class BAlphabet : Alphabet
{
    public BAlphabet()
    {
        character = "B";
        Console.WriteLine("Create new instance of B");
    }
}

//Step 4 (use simple factory)
public static class AlphabetFactory
{
    static Dictionary<string, Alphabet> dictionary;
    static AlphabetFactory()
    {
        dictionary = new Dictionary<string, Alphabet>();
    }
    public static Alphabet GetAlpha(string key)
    {
        if (!dictionary.ContainsKey(key))
        {
            Alphabet alphabet = null;
            switch (key)
            {
                case "A":
                    alphabet = new AAlphabet();
                    break;
                case "B":
                    alphabet = new BAlphabet();
                    break;
            }
            dictionary[key] = alphabet;
        }
        return dictionary[key];
    }
}
