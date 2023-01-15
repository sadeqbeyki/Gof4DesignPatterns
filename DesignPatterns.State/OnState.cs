namespace DesignPatterns.State;

//State step 2
public class OnState : IState
{
    public bool ChangeState()
    {
        Console.WriteLine("Turn it Off");
        return false;
    }
}
