namespace DesignPatterns.Iterator;

//Iterator Step 2
public class ListEnumerator : IMyEnum
{
    private readonly PersonCollection personCollection;
    private int _index = 0;
    public ListEnumerator(PersonCollection personCollection)
    {
        this.personCollection = personCollection;
    }

    public Person Current
    {
        get
        {
            return personCollection[_index];
        }
    }

    public Person MoveNext()
    {
        _index++;
        if (personCollection.Count() > _index)
        {
            return personCollection[_index];
        }
        return null;
    }
}

