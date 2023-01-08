namespace DesignPatterns.Composite;
//step 1 //Composite step 2 (inheriate INode)
public class Person : INode
{
    public string Name { get; set; }
    private int _score;
    public int Score
    {
        get
        {
            return _score;
        }
        set
        {
            _score = value;
            Console.WriteLine($"{Name} -> {_score}");
        }
    }
}
