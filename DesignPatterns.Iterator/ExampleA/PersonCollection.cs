namespace DP.Behavioral.Iterator.ExampleA;

//step 2
//Iterator Step 4 (inheriante)
public class PersonCollection : IMyEnumerable
{
    private List<Person> _people = new List<Person>();

    //Iterator Step 5 (this function)
    public IMyEnum GetEnumerator()
    {
        return new ListEnumerator(this);
    }

    public Person this[int index]
    {
        get
        {
            return _people[index];
        }
        set
        {
            _people[index] = value;
        }
    }

    public int Count()
    {
        return _people.Count;
    }
}
