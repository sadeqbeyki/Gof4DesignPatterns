namespace DesignPatterns.ChainOfResponsibility.ExampleA;

public class IsActiveUser : TransferMoney
{
    public IsActiveUser(TransferMoney successor) : base(successor)
    {
    }

    public override ResponseContext Execute(RequestContext requestContext)
    {
        if (requestContext.From.Active)
            return _successor.Execute(requestContext);

        return new ResponseContext
        {
            Message = "Inactive Account"
        };
    }
}
