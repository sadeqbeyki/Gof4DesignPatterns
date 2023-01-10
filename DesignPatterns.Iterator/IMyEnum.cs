namespace DesignPatterns.Iterator;

//Iterator Step 1
public interface IMyEnum
{
    Person Current { get;}
    Person MoveNext();
}

