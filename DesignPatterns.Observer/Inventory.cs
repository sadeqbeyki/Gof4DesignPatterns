namespace DesignPatterns.Observer;

//step 5
public class Inventory : ISubject
{
    public List<IObserver> Observers { get; set; } = new List<IObserver>();
    private int _product;

    public int Product
    {
        get { return _product; }
        set { 
            _product = value;
            foreach (var item in Observers)
            {
                item.Update();
            }
        }
    }

    public void Registration(IObserver observer)
    {
        Observers.Add(observer);
    }

    public void Remove(IObserver observer)
    {
        Observers.Remove(observer);
    }
}

