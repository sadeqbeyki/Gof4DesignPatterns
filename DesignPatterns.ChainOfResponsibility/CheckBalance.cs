namespace DesignPatterns.ChainOfResponsibility;

public class CheckBalance : TransferMoney
{
    public CheckBalance(TransferMoney successor) : base(successor)
    {
    }

    public override ResponseContext Execute(RequestContext requestContext)
    {
        if (requestContext.From.AccountValue >= requestContext.Value)
        {
            return _successor.Execute(requestContext);
        }
        return new ResponseContext
        {
            Message = "Invalid Value"
        };
    }
}
