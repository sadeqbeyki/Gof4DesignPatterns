using System.Linq.Expressions;

namespace DesignPatterns.Specification;

//Specification step 1
public abstract class Specification<T>
{
    //Specification step 7 (just this function)
    public static Specification<T> All()
    {
        return new AllSpecification<T>();
    }

    //از ورودی یک تایپ تی میگیرند و خروجی بولین
    public abstract Expression<Func<T, bool>> MyExpression();
    public bool IsSatisfiedBy(T input)
    {
        var predict = MyExpression().Compile();
        return predict(input);
    }

    //Specification step 9 (just this function)
    //hasDVD is left side > hasDVD in down code have And , and can give right side
    public Specification<T> And(Specification<T> right)
    {
        return new AndSpecification<T>(this, right);
    }
}
