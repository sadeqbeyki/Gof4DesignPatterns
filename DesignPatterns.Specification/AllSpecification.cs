using System.Linq.Expressions;

namespace DesignPatterns.Specification;

//Specification step 6
internal class AllSpecification<T> : Specification<T>
{
    public override Expression<Func<T, bool>> MyExpression()
    {
        return c => true;
    }
}
