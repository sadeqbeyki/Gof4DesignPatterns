namespace DesignPatterns.State;

//State step 3
public class OffState : IState
{
    public bool ChangeState()
    {
        Console.WriteLine("Turn it On");
        return true;
    }
}