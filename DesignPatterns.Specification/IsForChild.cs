using System.Linq.Expressions;

namespace DesignPatterns.Specification;

//Specification step 10
public class IsForChild : Specification<Movie>
{
    public override Expression<Func<Movie, bool>> MyExpression()
    {
        return c => c.availableAge == AvailableAge.PG || c.availableAge == AvailableAge.PG13;
    }
}
