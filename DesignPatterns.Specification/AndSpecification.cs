using System.Linq.Expressions;

namespace DesignPatterns.Specification;

//Specification step 8 
//And سمت چپ و راست دارد
internal class AndSpecification<T> : Specification<T>
{
    private readonly Specification<T> left;
    private readonly Specification<T> right;

    public AndSpecification(Specification<T> left, Specification<T> right)
    {
        this.left = left;
        this.right = right;
    }

    public override Expression<Func<T, bool>> MyExpression()
    {
        //سمت چپ و راست
        Expression<Func<T, bool>> leftExpression = left.MyExpression();
        Expression<Func<T, bool>> rightExpression = right.MyExpression();
        //دریافت پارامترها
        var param = leftExpression.Parameters[0];
        var paramExpression = Expression.Parameter(param.Type);
        //باهم میکنیم AND
        BinaryExpression body = Expression.AndAlso(leftExpression.Body, rightExpression.Body);

        body = (BinaryExpression)new ParameterReplacer(paramExpression).Visit(body);
        //ترکیبشون اکسپرشن جدید میشه و برمیگرده
        var finalExpression = Expression.Lambda<Func<T, bool>>(body, paramExpression);
        return finalExpression;
    }
}
