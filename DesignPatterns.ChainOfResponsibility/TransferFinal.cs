namespace DesignPatterns.ChainOfResponsibility;

public class TransferFinal : TransferMoney
{
    public TransferFinal(TransferMoney successor) : base(successor)
    {
    }

    public override ResponseContext Execute(RequestContext requestContext)
    {
        requestContext.From.AccountValue = requestContext.From.AccountValue - requestContext.Value;
        requestContext.To.AccountValue = requestContext.To.AccountValue + requestContext.Value;
        return new ResponseContext
        {
            Message = "Transfer Complete"
        };
    }
}
