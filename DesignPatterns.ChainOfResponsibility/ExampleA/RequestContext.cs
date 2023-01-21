namespace DesignPatterns.ChainOfResponsibility.ExampleA;

public class RequestContext
{
    public string Password { get; set; }
    public int Value { get; set; }
    public Customer From { get; set; }
    public Customer To { get; set; }
}
