//Specification step 2

using System.Linq.Expressions;

namespace DesignPatterns.Specification;

public class HasDVD : Specification<Movie>
{
    public override Expression<Func<Movie, bool>> MyExpression()
    {
        return c => c.CreationDate <= DateTime.Now.AddMonths(-6);
    }
}
