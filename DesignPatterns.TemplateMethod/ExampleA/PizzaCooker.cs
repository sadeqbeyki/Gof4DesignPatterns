namespace DesignPatterns.TemplateMethod.ExampleA;

public abstract class PizzaCooker
{
    public void Cook()
    {
        PrepareBread();
        PrepareIngridients();
        ComposeMaterials();
        StartCooking();
        SendToCustomer();
    }
    //اماده کردن نان
    public abstract void PrepareBread();
    //اماده کردن مواد لوازم
    public abstract void PrepareIngridients();
    //ترکیب مواد
    public void ComposeMaterials()
    {

    }
    //پختن
    public void StartCooking()
    {

    }
    //ارسال به مشتری
    public void SendToCustomer()
    {

    }
}
