namespace DesignPatterns.Specification;

public class Display
{
    public void Show(List<Movie> movies)
    {
        //Specification step 5
        var hasDVD = new HasDVD();
        //Specification step 11
        var isForChild = new IsForChild();
        var mySpecification = hasDVD.And(isForChild);

        foreach (var item in movies)
        {
            //Specification step 5  : if (spec.IsSatisfiedBy(item))
            ////Specification step 11
            if (mySpecification.IsSatisfiedBy(item))
            {
                Console.WriteLine($"{item.Name} Has DVD");
            }
        }
    }
}




//step 7

//public class Display
//{//دریافت فیمهایی که دی وی دی ورژن دارند و مشخص کردن آنها و یکی لیست مووی دریافت میکند
//    public void Show(List<Movie> movies)
//    {
//        //Specification step 5
//        var spec = new HasDVD();
//        foreach (var item in movies)
//        {
//            if (item.CreationDate <= DateTime.Now.AddMonths(-6))
//            {
//                Console.WriteLine($"{item.Name} Has DVD");
//            }
//        }
//    }
//}
