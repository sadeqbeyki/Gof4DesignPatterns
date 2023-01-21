namespace DesignPatterns.ChainOfResponsibility.ExampleA;

public class CheckPassword : TransferMoney
{
    public CheckPassword(TransferMoney successor) : base(successor)
    {
    }

    public override ResponseContext Execute(RequestContext requestContext)
    {
        if (requestContext.From.Password == requestContext.Password)
            return _successor.Execute(requestContext);

        return new ResponseContext
        {
            Message = "Incorrect Password"
        };

    }
}
