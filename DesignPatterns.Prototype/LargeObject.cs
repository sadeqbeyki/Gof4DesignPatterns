
namespace DesignPatterns.Prototype;

//prototype way2 and fix: ICloneable step 3
public class LargeObject : ICloneable<LargeObject>
{
    public int Count { get; set; } = 0;
    public InnerClass InnerClass { get; set; } = new InnerClass();
    public LargeObject Clone()
    {
        return (LargeObject)MemberwiseClone();
    }
}




//public class LargeObject : ICloneable
//{
//    //prototype way1: ICloneable step 1
//    public object Clone()
//    {
//        return MemberwiseClone();
//    }
//}
