namespace DesignPatterns.Mediator;

//Mediator step 4
public class Boeing : Airplane
{
    public Boeing(ITower tower, string uniqName) : base(tower)
    {
        AcceptanleDistance = 3000;
        Name = $"Boeing{uniqName}";
    }
}

//step 2

//public class Boeing : Airplane
//{
//    public Boeing(string uniqName)
//    {
//        Name = $"Boeing{uniqName}";
//        AcceptanleDistance = 1000;
//    }

//    public override bool AllowChange()
//    {
//        var result = false;
//        //به ازای همه لیست های هواپیما ها چک کنیم فاصله مجازشان را
//        foreach (var item in Airplanes)
//        {
//            if (item is Boeing)
//            {
//                var temp = item as Boeing;
//                //calc result
//            }
//            if (item is Airbus)
//            {
//                var temp = item as Airbus;
//                //calc result
//            }
//            if (item is Lilium)
//            {
//                var temp = item as Lilium;
//                //calc result
//            }
//        }
//        return result;
//    }
//}
