
namespace DesignPatterns.Prototype;

//prototype way2 and fix: ICloneable step 1
public class InnerClass
{
    public int Count { get; set; }
}




//public class LargeObject : ICloneable
//{
//    //prototype way1: ICloneable step 1
//    public object Clone()
//    {
//        return MemberwiseClone();
//    }
//}
