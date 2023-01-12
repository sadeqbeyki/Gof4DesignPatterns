namespace DesignPatterns.Observer;
//step 1
public interface ISubject
{
    List<IObserver> Observers { get; set; }
    void Registration(IObserver observer);
    void Remove(IObserver observer);
}

