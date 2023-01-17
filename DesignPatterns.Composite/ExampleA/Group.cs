namespace DP.Structural.Composite.ExampleA;

//Composite step 3
public class Group : INode
{
    public string Name { get; set; }
    public List<INode> Nodes { get; set; }

    public int Score
    {
        get
        {
            int score = 0;
            foreach (var node in Nodes)
            {
                score += node.Score;
            }
            return score;
        }
        set
        {
            var individualValue = value / Nodes.Count;
            Console.WriteLine($"Proccess value of {Name}");
            foreach (var node in Nodes)
            {
                node.Score = individualValue;
            }
        }
    }
}

//step 2
//public class Group : INode
//{
//    public string Name { get; set; }
//    public List<Person> People { get; set; }
//}
