namespace DesignPatterns.Specification;
//step 2

public class Movie
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreationDate { get; set; }
    public AvailableAge availableAge { get; set; }
}
