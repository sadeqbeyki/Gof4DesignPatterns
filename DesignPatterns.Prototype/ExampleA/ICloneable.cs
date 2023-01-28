namespace DP.Creational.Prototype.ExampleA;

//prototype way2 and fix: ICloneable step 2
public interface ICloneable<T>
{
    T Clone();
}




//public class LargeObject : ICloneable
//{
//    //prototype way1: ICloneable step 1
//    public object Clone()
//    {
//        return MemberwiseClone();
//    }
//}
