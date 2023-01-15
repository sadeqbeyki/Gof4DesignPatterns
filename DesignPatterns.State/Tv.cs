namespace DesignPatterns.State;
//State step 4
public class Tv
{
    private IState _state;
    private bool isOn;
    public bool IsOn
    {
        get
        {
            return isOn;
        }
        set
        {
            isOn= value;
            _state = isOn ? new OnState() :new OffState();
        }
    }

    public Tv()
    {
        _state = new OffState();
    }

    public void OnOffBtnPush()
    {
        IsOn = _state.ChangeState();
    }
}


//step 1
//public class Tv
//{
//    private bool IsOn;
//    public void OnOffBtnPush()
//    {
//        if (IsOn)
//        {
//            Console.WriteLine("Turn it Off");
//            IsOn = false;
//        }
//        else
//        {
//            Console.WriteLine("Turn it ON");
//            IsOn = true;
//        }
//    }
//}
