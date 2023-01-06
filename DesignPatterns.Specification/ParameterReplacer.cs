using System.Linq.Expressions;

namespace DesignPatterns.Specification;

//Specification step 9
internal class ParameterReplacer : ExpressionVisitor
{
    private readonly ParameterExpression _parameter;
    public ParameterReplacer(ParameterExpression parameter)
    {
        _parameter = parameter;
    }

    protected override Expression VisitParameter(ParameterExpression node)
    {
        return base.VisitExtension(_parameter);
    }
}
